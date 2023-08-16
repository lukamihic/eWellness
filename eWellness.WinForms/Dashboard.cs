﻿using eWellness.Core.Models;
using System.Windows.Forms;

namespace eWellness.WinForms
{
    public partial class Dashboard : Form
    {
        private readonly APIService _servicesService = new APIService("Services");
        private readonly APIService _appointmentsService = new APIService("Appointments");
        private readonly APIService _clientsService = new APIService("Clients");
        private readonly APIService _specialOffersService = new APIService("SpecialOffers");
        private readonly APIService _paymentsService = new APIService("Payments");
        protected readonly object initialQuery = new { pageSize = 10, pageNumber = 1, descendingSort = false };

        public Dashboard()
        {
            InitializeComponent();
            lblUser.Text = Session.LoggedUser;
            Toggle(Session.ActiveMenu == "Usluge" ? lblServices : Session.ActiveMenu == "Termini" ? lblAppointments : Session.ActiveMenu == "Klijenti" ? lblClients : Session.ActiveMenu == "Popusti" ? lblDiscount : lblPayments);

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Toggle(Session.ActiveMenu == "Usluge" ? lblServices : Session.ActiveMenu == "Termini" ? lblAppointments : Session.ActiveMenu == "Klijenti" ? lblClients : Session.ActiveMenu == "Popusti" ? lblDiscount : lblPayments);
        }

        protected async void Toggle(Label label)
        {
            dataGridView1.AutoGenerateColumns = false;
            Session.ActiveMenu = label.Text.Trim();
            switch (label.Text.Trim())
            {
                case "Usluge":
                    lblServices.Font = new Font(lblServices.Font, FontStyle.Bold);
                    lblClients.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblDiscount.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblPayments.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblAppointments.Font = new Font(lblServices.Font, FontStyle.Regular);
                    
                    lnkPaymentMethods.Visible = false;
                    lnkServiceCategories.Visible = true;

                    progressBar1.Visible= false;
                    lblNoApt.Visible= false;
                    lblPercent.Visible= false;
                    lblToday.Visible= false;    

                    var ds1 = await _servicesService.Get<List<Service>>(initialQuery);
                    dataGridView1.DataSource = ds1;

                    break;
                case "Klijenti":
                    lblServices.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblClients.Font = new Font(lblServices.Font, FontStyle.Bold);
                    lblDiscount.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblPayments.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblAppointments.Font = new Font(lblServices.Font, FontStyle.Regular);

                    lnkPaymentMethods.Visible = false;
                    lnkServiceCategories.Visible = false;

                    progressBar1.Visible = false;
                    lblNoApt.Visible = false;
                    lblPercent.Visible = false;
                    lblToday.Visible = false;

                    var ds2 = await _clientsService.Get<List<Client>>(initialQuery);
                    ds2.ForEach(ds => ds.Name = ds.User!.Name ?? "N/A");

                    dataGridView1.DataSource = ds2;
                    break;
                case "Termini":
                    lblServices.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblClients.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblDiscount.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblPayments.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblAppointments.Font = new Font(lblServices.Font, FontStyle.Bold);
                    
                    lnkPaymentMethods.Visible = false;
                    lnkServiceCategories.Visible = false;

                    progressBar1.Visible = true;
                    lblPercent.Visible = true;
                    lblToday.Visible = true;

                    var ds3 = await _appointmentsService.Get<List<Appointment>>(initialQuery);
                    ds3.ForEach(ds => ds.Name = $"{ds.Service.Name} za: {ds.Client!.User!.Name ?? "N/A"} ({ds.StartTime} - {ds.EndTime})");

                    var todayCount = ds3.Count(d => d.StartTime.Date == DateTime.Now.Date && !d.IsDeleted);
                    var percent = ((todayCount == 0 ? ds3.Count() : ds3.Count(d => d.StartTime < DateTime.Now)) / ds3.Count()) * 100m;
                    lblPercent.Text = $"{percent}%";
                    progressBar1.Value = int.Parse(percent.ToString());

                    lblNoApt.Visible = todayCount == 0;

                    dataGridView1.DataSource = ds3;
                    break;
                case "Popusti":
                    lblServices.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblClients.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblDiscount.Font = new Font(lblServices.Font, FontStyle.Bold);
                    lblPayments.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblAppointments.Font = new Font(lblServices.Font, FontStyle.Regular);

                    lnkPaymentMethods.Visible = false;
                    lnkServiceCategories.Visible = false;

                    progressBar1.Visible = false;
                    lblNoApt.Visible = false;
                    lblPercent.Visible = false;
                    lblToday.Visible = false;

                    var ds4 = await _specialOffersService.Get<List<SpecialOffer>>(initialQuery);
                    ds4.ForEach(ds => ds.Name = $"{ds.Name} (vrijedi do: {ds.OfferExpirationDate.ToShortDateString()})" ?? "N/A");

                    dataGridView1.DataSource = ds4;
                    break;
                case "Uplate":
                    lblServices.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblClients.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblDiscount.Font = new Font(lblServices.Font, FontStyle.Regular);
                    lblPayments.Font = new Font(lblServices.Font, FontStyle.Bold);
                    lblAppointments.Font = new Font(lblServices.Font, FontStyle.Regular);

                    lnkPaymentMethods.Visible = true;
                    lnkServiceCategories.Visible = false;

                    progressBar1.Visible = false;
                    lblNoApt.Visible = false;
                    lblPercent.Visible = false;
                    lblToday.Visible = false;

                    var ds5 = await _paymentsService.Get<List<Payment>>(initialQuery);
                    ds5.ForEach(ds => ds.Name = $"{ds.Appointment!.Client!.User!.Name ?? "N/A"} - {ds.Appointment!.StartTime.ToShortDateString() ?? "01-01-0000"} => {ds.Amount}KM" ?? "N/A");

                    dataGridView1.DataSource = ds5;
                    break;
                default:
                    break;
            }
        }


        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }

        private void lblServices_Click(object sender, EventArgs e)
        {
            Toggle(lblServices);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Toggle(lblServices);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Toggle(lblAppointments);
        }

        private void lblAppointments_Click(object sender, EventArgs e)
        {
            Toggle(lblAppointments);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Toggle(lblClients);
        }

        private void lblClients_Click(object sender, EventArgs e)
        {
            Toggle(lblClients);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Toggle(lblDiscount);
        }

        private void lblDiscount_Click(object sender, EventArgs e)
        {
            Toggle(lblDiscount);
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Toggle(lblPayments);
        }

        private void lblPayments_Click(object sender, EventArgs e)
        {
            Toggle(lblPayments);
        }


        private void panel3_Click(object sender, EventArgs e)
        {
            Toggle(lblServices);
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            Toggle(lblAppointments);
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Toggle(lblClients);
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            Toggle(lblDiscount);
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            Toggle(lblPayments);
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }

        private void lnkPaymentMethods_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var paymentMethods = new PaymentMethods();
            paymentMethods.Show();
        }

        private void lnkServiceCategories_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var serviceCategories = new ServiceCategories();
            serviceCategories.Show();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex  == 4)
            {
                var obj = dataGridView1.Rows[e.RowIndex];
                var id = int.Parse(obj.Cells[0].Value.ToString() ?? "-1");
                var confirmResult = MessageBox.Show("Sigurno želite obrisati ovaj zapis?",
                                     "Brisanje!!",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        switch (Session.ActiveMenu)
                        {
                            case "Usluge":
                                await _servicesService.Delete<Service>(id);
                                MessageBox.Show("Uspješno ste obrisali stavku", "Uspjeh!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                Toggle(lblServices);
                                break;
                            case "Klijenti":
                                await _clientsService.Delete<Client>(id);
                                MessageBox.Show("Uspješno ste obrisali stavku", "Uspjeh!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                Toggle(lblClients);
                                break;
                            case "Termini":
                                await _appointmentsService.Delete<Appointment>(id);
                                MessageBox.Show("Uspješno ste obrisali stavku", "Uspjeh!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                Toggle(lblAppointments);
                                break;
                            case "Popusti":
                                await _specialOffersService.Delete<SpecialOffer>(id);
                                MessageBox.Show("Uspješno ste obrisali stavku", "Uspjeh!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                Toggle(lblDiscount);
                                break;
                            case "Uplate":
                                await _paymentsService.Delete<Payment>(id);
                                MessageBox.Show("Uspješno ste obrisali stavku", "Uspjeh!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                Toggle(lblPayments);
                                break;
                            default:
                                break;
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show($"Dogodila se greška prilikom brisanja: \n {ex.Message}", "Greška", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                    }
                }
            }
            if(e.ColumnIndex == 2)
            {
                var obj = dataGridView1.Rows[e.RowIndex];
                var id = int.Parse(obj.Cells[0].Value.ToString() ?? "-1");

                switch (Session.ActiveMenu)
                {
                    case "Usluge":
                        this.Hide();
                        var services = new Services(id);
                        services.Show();
                        break;
                    case "Termini":
                        this.Hide();
                        var appointments = new Appointments(id);
                        appointments.Show();
                        break;
                    case "Klijenti":
                        this.Hide();
                        var clients = new Clients(id);
                        clients.Show();
                        break;
                    case "Popusti":
                        this.Hide();
                        var specialOffers = new SpecialOffers(id);
                        specialOffers.Show();
                        break;
                    case "Uplate":
                        this.Hide();
                        var payments = new Payments(id);
                        payments.Show();
                        break;
                    default:
                        break;
                }
            }
            if (e.ColumnIndex == 3)
            {
                var obj = dataGridView1.Rows[e.RowIndex];
                var id = int.Parse(obj.Cells[0].Value.ToString() ?? "-1");

                switch (Session.ActiveMenu)
                {
                    case "Usluge":
                        this.Hide();
                        var services = new Services(id, true);
                        services.Show();
                        break;
                    case "Termini":
                        this.Hide();
                        var appointments = new Appointments(id, true);
                        appointments.Show();
                        break;
                    case "Klijenti":
                        this.Hide();
                        var clients = new Clients(id, true);
                        clients.Show();
                        break;
                    case "Popusti":
                        this.Hide();
                        var specialOffers = new SpecialOffers(id, true);
                        specialOffers.Show();
                        break;
                    case "Uplate":
                        this.Hide();
                        var payments = new Payments(id, true);
                        payments.Show();
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (Session.ActiveMenu)
            {
                case "Usluge":
                    var services = new Services(null, true);
                    services.Show();
                    break;
                case "Termini":
                    var appointments = new Appointments(null, true);
                    appointments.Show();
                    break;
                case "Klijenti":
                    this.Hide();
                    var clients = new Clients(null, true);
                    clients.Show();
                    break;
                case "Popusti":
                    this.Hide();
                    var specialOffers = new SpecialOffers(null, true);
                    specialOffers.Show();
                    break;
                case "Uplate":
                    this.Hide();
                    var payments = new Payments(null, true);
                    payments.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
