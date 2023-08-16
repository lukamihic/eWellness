using eWellness.Core.Models;
using Flurl.Util;
using System.Windows.Forms;
using System.Xml.Linq;

namespace eWellness.WinForms
{
    public partial class Appointments : Form
    {
        private readonly APIService _servicesService = new APIService("Services");
        private readonly APIService _appointmentsService = new APIService("Appointments");
        private readonly APIService _clientsService = new APIService("Clients");
        private readonly APIService _employeesService = new APIService("Employees");
        private readonly APIService _specialOffersService = new APIService("SpecialOffers");
        protected int? appointmentId = null;
        public Appointments(int? id = null, bool isEditable = false)
        {
            InitializeComponent();
            appointmentId = id;

            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "MM/dd/yyyy hh:mm";

            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "MM/dd/yyyy hh:mm";

            if (!isEditable)
            {
                cmbClient.Enabled = false;
                cmbEmployee.Enabled = false;
                cmbService.Enabled = false;
                cmbSpecialOffer.Enabled = false;
                dtpStartTime.Enabled = false;
                dtpEndTime.Enabled = false;
                txtNotes.Enabled = false;
                txtPrice.Enabled = false;
                txtStatus.Enabled = false;
                btnSave.Visible = false;
            }
        }

        private async void Appointments_Load(object sender, EventArgs e)
        {
            var clients = new Dictionary<int, string>();
            foreach (var cl in await _clientsService.Get<List<Client>>())
            {
                clients.Add(cl.Id, cl.User!.Name ?? "N/A");
            }
            cmbClient.DataSource = new BindingSource(clients, null);
            cmbClient.DisplayMember = "Value";
            cmbClient.ValueMember = "Key";

            var employees = new Dictionary<int, string>();
            foreach (var em in await _employeesService.Get<List<Employee>>())
            {
                employees.Add(em.Id, em.User!.Name ?? "N/A");
            }
            cmbEmployee.DataSource = new BindingSource(employees, null);
            cmbEmployee.DisplayMember = "Value";
            cmbEmployee.ValueMember = "Key";

            var services = new Dictionary<int, string>();
            foreach (var svc in await _servicesService.Get<List<Service>>())
            {
                services.Add(svc.Id, svc.Name ?? "N/A");
            }
            cmbService.DataSource = new BindingSource(services, null);
            cmbService.DisplayMember = "Value";
            cmbService.ValueMember = "Key";

            var specialOffers = new Dictionary<int, string>();
            specialOffers.Add(0, string.Empty);
            foreach (var so in await _specialOffersService.Get<List<SpecialOffer>>())
            {
                specialOffers.Add(so.Id, so.Name ?? "N/A");
            }
            cmbSpecialOffer.DataSource = new BindingSource(specialOffers, null);
            cmbSpecialOffer.DisplayMember = "Value";
            cmbSpecialOffer.ValueMember = "Key";

            if (appointmentId.HasValue)
            {
                var appointment = await _appointmentsService.GetById<Appointment>(appointmentId.Value);
                cmbClient.SelectedValue = appointment.ClientId;
                cmbEmployee.SelectedValue = appointment.EmployeeId;
                cmbService.SelectedValue = appointment.ServiceId;
                cmbSpecialOffer.SelectedValue = appointment.SpecialOfferId ?? 0;
                dtpStartTime.Value = appointment.StartTime;
                dtpEndTime.Value = appointment.EndTime;
                txtNotes.Text = appointment.Notes;
                txtPrice.Text = appointment.TotalPrice.ToString();
                txtStatus.Text = appointment.Status;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (appointmentId.HasValue)
                {
                    await _appointmentsService.Put<Appointment>(appointmentId.GetValueOrDefault(), new { clientId = cmbClient.SelectedValue, employeeId = cmbEmployee.SelectedValue, serviceId = cmbService.SelectedValue, specialOfferId = (int)cmbSpecialOffer.SelectedValue == 0 ? null : cmbSpecialOffer.SelectedValue, notes = txtNotes.Text, status = txtStatus.Text, totalPrice = decimal.Parse(txtPrice.Text), startTime = dtpStartTime.Value.ToInvariantString(), endTime = dtpEndTime.Value.ToInvariantString() });
                }
                else
                {
                    var client = (await _clientsService.Get<List<Client>>()).FirstOrDefault(c => c.Id == (int)cmbClient.SelectedValue);
                    await _clientsService.Put<Client>(client!.Id, new { lastAppointment = dtpStartTime.Value.ToInvariantString(), totalAppointments = client.TotalAppointments + 1, isMember = client.IsMember, membershipExpirationDate = client.MembershipExpirationDate.ToInvariantString(), userId = client.UserId });
                    await _appointmentsService.Post<Appointment>(new { clientId = cmbClient.SelectedValue, employeeId = cmbEmployee.SelectedValue, serviceId = cmbService.SelectedValue, specialOfferId = (int)cmbSpecialOffer.SelectedValue == 0 ? null : cmbSpecialOffer.SelectedValue, notes = txtNotes.Text, status = txtStatus.Text, totalPrice = decimal.Parse(txtPrice.Text), startTime = dtpStartTime.Value.ToInvariantString(), endTime = dtpEndTime.Value.ToInvariantString() });
                }
                MessageBox.Show("Uspješno ste spasili promjene");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dogodila se greška: \n{ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void Appointments_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
