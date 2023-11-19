using eWellness.WinForms;
using eWellness.Core.Models;

namespace eWellness.WinForms
{
    public partial class Login : Form
    {

        private readonly APIService _employeeService = new APIService("Employees");
        public Login()
        {
            InitializeComponent();
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            var employeeDictionary = new Dictionary<int, string>();
            foreach (var employee in await _employeeService.Get<List<Employee>>()) {
                employeeDictionary.Add(employee.Id, employee.User.Name);
            }
            cmbKorisnik.DataSource = new BindingSource(employeeDictionary, null);
            cmbKorisnik.DisplayMember = "Value";
            cmbKorisnik.ValueMember = "Key";
            lblUcitavanje.Visible = false;
            cmbKorisnik.Enabled = true;
            btnPrijava.Enabled = true;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            Session.LoggedUser = cmbKorisnik.Text;
            var dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}