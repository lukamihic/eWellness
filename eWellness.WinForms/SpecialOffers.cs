using eWellness.Core.Models;
using Flurl.Util;

namespace eWellness.WinForms
{
    public partial class SpecialOffers : Form
    {
        private readonly APIService _specialOffersService = new APIService("SpecialOffers");
        protected int? specialOfferId = null;
        public SpecialOffers(int? id = null, bool isEditable = false)
        {
            InitializeComponent();
            specialOfferId = id;
            if (!isEditable)
            {
                txtDescription.Enabled = false;
                txtName.Enabled = false;
                dtpOfferExpirationDate.Enabled = false;
                cbIsActive.Enabled = false;
                btnSave.Visible = false;
            } 
        }

        private async void SpecialOffers_Load(object sender, EventArgs e)
        {
            if (specialOfferId.HasValue)
            {
                var offer = await _specialOffersService.GetById<SpecialOffer>(specialOfferId.Value);

                txtDescription.Text = offer.Description;
                txtName.Text = offer.Name;
                cbIsActive.Checked = offer.IsActive;
                dtpOfferExpirationDate.Value = offer.OfferExpirationDate.Year < 1900 ? DateTime.Now : offer.OfferExpirationDate;
                if (offer.OfferExpirationDate.Date < DateTime.Now.Date && offer.IsActive)
                    lblExpired.Visible = true;
                if (offer.IsActive && cbIsActive.Enabled)
                    dtpOfferExpirationDate.Enabled = true;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (specialOfferId.HasValue)
                {

                    await _specialOffersService.Put<SpecialOffer>(specialOfferId.GetValueOrDefault(), new { name = txtName.Text, description = txtDescription.Text, isActive = cbIsActive.Checked, offerExpirationDate = dtpOfferExpirationDate.Value.ToInvariantString() });
                }
                else
                {
                    await _specialOffersService.Post<SpecialOffer>(new { name = txtName.Text, description = txtDescription.Text, isActive = cbIsActive.Checked, offerExpirationDate = dtpOfferExpirationDate.Value.ToInvariantString() });
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

        private void SpecialOffers_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dashboard = new Dashboard();
            dashboard.Show();
        }

        private void cbIsActive_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Checked && cbIsActive.Enabled)
                dtpOfferExpirationDate.Enabled = true;
            else
                dtpOfferExpirationDate.Enabled = false;
        }
    }
}
