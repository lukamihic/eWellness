using eWellness.Core.Common.Models;
using eWellness.Core.Models;
using Flurl.Util;
using Microsoft.VisualBasic.ApplicationServices;
using System.Net;
using User = eWellness.Core.Models.User;

namespace eWellness.WinForms
{
    public partial class Clients : Form
    {
        private readonly APIService _clientsService = new APIService("Clients");
        private readonly APIService _usersService = new APIService("Users");
        protected int? clientId = null;
        protected int? userId = null;
        public Clients(int? id = null, bool isEditable = false)
        {
            InitializeComponent();
            clientId = id;
            if (!isEditable)
            {
                txtAddress.Enabled = false;
                txtEmail.Enabled = false;
                txtName.Enabled = false;
                txtPhone.Enabled = false;
                cmbGender.Enabled = false;
                dtpDateOfBirth.Enabled = false;
                cbIsMember.Enabled = false;
                dtpMembershipExpirationDate.Enabled = false;
                btnSave.Visible = false;
            }
            if(clientId is null)
            {
                lblLastInfo.Visible = false;
                lblLastAppointment.Visible = false;
                lblN.Visible = false;
            }
        }

        private async void Clients_Load(object sender, EventArgs e)
        {
            if (clientId.HasValue)
            {
                var client = await _clientsService.GetById<Client>(clientId.Value);
                txtAddress.Text = client.User!.Address;
                txtEmail.Text = client.User!.Email;
                txtName.Text = client.User!.Name;
                txtPhone.Text = client.User!.Phone;
                cmbGender.SelectedIndex = client.User!.Gender == 'M' ? 1 : 2;
                dtpDateOfBirth.Value = client.User!.DateOfBirth;
                cbIsMember.Checked = client.IsMember;
                dtpMembershipExpirationDate.Value = client.MembershipExpirationDate.Year < 1900 ? DateTime.Now : client.MembershipExpirationDate;
                if (client.MembershipExpirationDate.Date < DateTime.Now.Date && client.IsMember)
                    lblExpired.Visible = true;
                lblLastAppointment.Text = client.LastAppointment.ToShortDateString();
                lblN.Text = client.TotalAppointments.ToString();
                userId = client.UserId;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientId.HasValue)
                {

                    await _usersService.Put<User>(userId.GetValueOrDefault(), new { name = txtName.Text, email = txtEmail.Text, phone = txtPhone.Text, address =  txtAddress.Text, dateOfBirth = dtpDateOfBirth.Value.ToInvariantString(), gender = cmbGender.SelectedIndex == 1 ? "M" : "F", emergencyContactName = "N/A", emergencyContactPhone = "N/A" });
                    await _clientsService.Put<Client>(clientId.GetValueOrDefault(), new { totalAppointments = 0, isMember = cbIsMember.Checked, membershipExpirationDate = cbIsMember.Checked ? dtpMembershipExpirationDate.Value.ToInvariantString() : DateTime.MinValue.ToInvariantString(), userId = userId });
                }
                else
                {
                    var user = await _usersService.Post<User>(new { name = txtName.Text, email = txtEmail.Text, phone = txtPhone.Text, address = txtAddress.Text, dateOfBirth = dtpDateOfBirth.Value.ToInvariantString(), gender = cmbGender.SelectedIndex == 1 ? "M" : "F", emergencyContactName = "N/A", emergencyContactPhone = "N/A" });
                    await _clientsService.Post<Client>(new { totalAppointments = 0, isMember = cbIsMember.Checked, membershipExpirationDate = cbIsMember.Checked ? dtpMembershipExpirationDate.Value.ToInvariantString() : DateTime.MinValue.ToInvariantString(), userId = user.Id });
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

        private void Clients_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dashboard = new Dashboard();
            dashboard.Show();
        }

        private void cbIsMember_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsMember.Checked)
                dtpMembershipExpirationDate.Enabled = true;
            else
                dtpMembershipExpirationDate.Enabled = false;
        }
    }
}
