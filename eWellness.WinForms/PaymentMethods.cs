using eWellness.Core.Models;

namespace eWellness.WinForms
{
    public partial class PaymentMethods : Form
    {
        private readonly APIService _paymentMethodsService = new APIService("PaymentMethods");
        protected readonly object initialQuery = new { pageSize = 10, pageNumber = 1, descendingSort = false };

        public PaymentMethods()
        {
            InitializeComponent();
        }

        private async void PaymentMethods_Load(object sender, EventArgs e)
        {
            var ds = await _paymentMethodsService.Get<List<PaymentMethod>>(initialQuery);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds;
        }
    }
}
