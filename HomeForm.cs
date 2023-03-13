using ManagementSystem.Configurations;
using ManagementSystem.DataModels;
using ManagementSystem.Scripts;

namespace ManagementSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            FormController.OpenEmployeeForm();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnProjects;
            LoadData();
        }

        private void LoadData()
        {
            dgvNews.AutoGenerateColumns = false;
            using (EmployeeDbContext db = new EmployeeDbContext())
            {
                dgvNews.DataSource = db.NewsModel.ToList<News>();
            }
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            FormController.OpenProjectsForm();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormController.OpenReportsForm();
        }

        private void HomeForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void HomeForm_DoubleClick(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
