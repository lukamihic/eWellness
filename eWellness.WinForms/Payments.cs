using eWellness.Core.Common.Models;
using eWellness.Core.Models;
using Flurl.Util;
using System.Net;
using System.Xml.Linq;

namespace eWellness.WinForms
{
    public partial class Payments : Form
    {
        private readonly APIService _paymentsService = new APIService("Payments");
        private readonly APIService _paymentMethodsService = new APIService("PaymentMethods");
        private readonly APIService _appointmentsService = new APIService("Appointments");
        protected readonly object initialQuery = new { pageSize = int.MaxValue, pageNumber = 1, descendingSort = false };
        protected int? paymentId = null;
        public Payments(int? id = null, bool isEditable = false)
        {
            InitializeComponent();
            paymentId = id;
            if (!isEditable)
            {
                txtAmount.Enabled = false;
                txtFees.Enabled = false;
                txtTransactionId.Enabled = false;
                cmbAppointment.Enabled = false;
                cmbPaymentMethod.Enabled = false;
                dtpDate.Enabled = false;
                btnSave.Visible = false;
            }
            if (id is null)
            {
                txtTransactionId.Text = Guid.NewGuid().ToString();
                txtAmount.Text = "0.00";
            }
        }

        private async void Payments_Load(object sender, EventArgs e)
        {
            var dsAppointments = new Dictionary<int, string>
            {
                { 0, string.Empty }
            };
            foreach (var ds in await _appointmentsService.Get<List<Appointment>>())
            {
                dsAppointments.Add(ds.Id, $"{ds.Client!.User!.Name ?? "N/A"} - {ds.StartTime.ToShortDateString() ?? "01-01-0000"} => {ds.TotalPrice}KM");
            }

            cmbAppointment.DisplayMember = "Value";
            cmbAppointment.ValueMember = "Key";
            cmbAppointment.DataSource = new BindingSource(dsAppointments, null);


            var dsPaymentMethods = new Dictionary<int, string>
            {
                { 0, string.Empty }
            };
            foreach (var cl in await _paymentMethodsService.Get<List<PaymentMethod>>())
            {
                dsPaymentMethods.Add(cl.Id, cl.Name ?? "N/A");
            }

            cmbPaymentMethod.DisplayMember = "Value";
            cmbPaymentMethod.ValueMember = "Key";
            cmbPaymentMethod.DataSource = new BindingSource(dsPaymentMethods, null);

            if(paymentId.HasValue)
            {
                var payment = await _paymentsService.GetById<Payment>(paymentId.Value);
                txtAmount.Text = payment.Amount.ToString();
                txtFees.Text = payment.Fees.ToString();
                cmbPaymentMethod.SelectedValue = payment.PaymentMethodId;
                cmbAppointment.SelectedValue = payment.AppointmentId;
                dtpDate.Value = payment.Date;
                txtTransactionId.Text = payment.TransactionId.ToString();
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (paymentId.HasValue)
                {
                    await _paymentsService.Put<Payment>(paymentId.GetValueOrDefault(), new { amount = decimal.Parse(txtAmount.Text), fees = decimal.Parse(txtFees.Text), appointmentId = (int)cmbAppointment.SelectedValue, paymentMethodId = (int)cmbPaymentMethod.SelectedValue, transactionId = txtTransactionId.Text, date = dtpDate.Value.ToInvariantString() });
                }
                else
                {
                    await _paymentsService.Post<Payment>(new { amount = decimal.Parse(txtAmount.Text), fees = decimal.Parse(txtFees.Text), appointmentId = (int)cmbAppointment.SelectedValue, paymentMethodId = (int)cmbPaymentMethod.SelectedValue, transactionId = txtTransactionId.Text, date = dtpDate.Value.ToInvariantString() });
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

        private async void cmbAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAppointment.SelectedIndex != 0) {
                var appointment = await _appointmentsService.GetById<Appointment>((int)cmbAppointment.SelectedValue);
                if (appointment is not null)
                {
                    txtAmount.Text = appointment.TotalPrice.ToString();
                    lblTotal.Text = $"{appointment.TotalPrice + (decimal.Parse(!String.IsNullOrWhiteSpace(txtFees.Text) ? txtFees.Text : "0.00"))}";
                }
            }
        }

        private void Payments_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dashboard = new Dashboard();
            dashboard.Show();
        }

        private void txtFees_TextChanged(object sender, EventArgs e)
        {
            lblTotal.Text = $"{(decimal.Parse(!String.IsNullOrWhiteSpace(txtAmount.Text) ? txtAmount.Text : "0.00")) + (decimal.Parse(!String.IsNullOrWhiteSpace(txtFees.Text) ? txtFees.Text : "0.00"))}";
        }
    }
}
