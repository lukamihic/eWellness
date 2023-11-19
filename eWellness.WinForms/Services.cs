using eWellness.Core.Models;
using System.Diagnostics;
using System.Globalization;

namespace eWellness.WinForms
{
    public partial class Services : Form
    {
        private readonly APIService _servicesService = new APIService("Services");
        private readonly APIService _serviceCategoriesService = new APIService("ServiceCategories");
        protected int? serviceId = null;

        public Services(int? id = null, bool isEditable = false)
        {
            InitializeComponent();
            serviceId = id;
            if(!isEditable) {
                txtDescription.Enabled= false;
                txtName.Enabled= false;
                txtDuration.Enabled= false;
                txtImageUrl.Visible= false; 
                txtPrice.Enabled= false;
                cmbServiceCategory.Enabled= false;
                btnSave.Visible = false;
                lnkImageURL.Visible = true;
            }
        }

        private async void Services_Load(object sender, EventArgs e)
        {
            var serviceCategories = new Dictionary<int, string>();
            foreach (var sc in await _serviceCategoriesService.Get<List<ServiceCategory>>())
            {
                serviceCategories.Add(sc.Id, sc.Name);
            }
            cmbServiceCategory.DataSource = new BindingSource(serviceCategories, null);
            cmbServiceCategory.DisplayMember = "Value";
            cmbServiceCategory.ValueMember = "Key";
            if (serviceId.HasValue)
            {
                var service = await _servicesService.GetById<Service>(serviceId.Value);
                txtName.Text = service.Name;
                txtDescription.Text = service.Description;
                txtDuration.Text = service.Duration.ToString();
                cmbServiceCategory.SelectedValue = service.ServiceCategoryId;
                txtPrice.Text = service.Price.ToString();
                txtImageUrl.Text = service.ImageUrl;
                lnkImageURL.Text = service.ImageUrl;
            }
        }

        private void lnkImageURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:{txtImageUrl.Text.Trim()}") { CreateNoWindow = true });
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (serviceId.HasValue)
                {
                    await _servicesService.Put<Service>(serviceId.GetValueOrDefault(), new { name = txtName.Text, description = txtDescription.Text, duration = txtDuration.Text, serviceCategoryId = cmbServiceCategory.SelectedValue, price = decimal.Parse(txtPrice.Text), imageUrl = txtImageUrl.Text });
                }
                else
                {
                    await _servicesService.Post<Service>(new { name = txtName.Text, description = txtDescription.Text, duration = txtDuration.Text, serviceCategoryId = cmbServiceCategory.SelectedValue, price = decimal.Parse(txtPrice.Text), imageUrl = txtImageUrl.Text });
                }
                MessageBox.Show("Uspješno ste spasili promjene");
                this.Close();
                var dashboard = new Dashboard();
                dashboard.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dogodila se greška: \n{ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }

        private void Services_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dashboard = new Dashboard();
            dashboard.Show();
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtName, "Ime ne smije biti prazno!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, "");
            }
        }
    }
}
