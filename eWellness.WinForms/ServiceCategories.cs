using eWellness.Core.Models;

namespace eWellness.WinForms
{
    public partial class ServiceCategories : Form
    {
        private readonly APIService _serviceCategoriesService = new APIService("ServiceCategories");
        protected readonly object initialQuery = new { pageSize = 10, pageNumber = 1, descendingSort = false };

        public ServiceCategories()
        {
            InitializeComponent();
        }

        private async void PaymentMethods_Load(object sender, EventArgs e)
        {
            var ds = await _serviceCategoriesService.Get<List<ServiceCategory>>(initialQuery);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds;
        }
    }
}
