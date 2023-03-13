using ManagementSystem.Configurations;
using ManagementSystem.DataModels;
using ManagementSystem.Scripts;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem
{
    public partial class ReportsForm : Form
    {
        Reports reportsModel = new Reports();
        News newsModel = new News();

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = dgvReports;
            btnDeleteReport.Enabled = false;
            btnPostReport.Enabled = false;
            LoadData();
        }

        private void LoadData()
        {
            dgvReports.AutoGenerateColumns = false;
            using (EmployeeDbContext db = new EmployeeDbContext())
            {
                dgvReports.DataSource = db.ReportsModel.ToList<Reports>();
            }
        }

        private void ReportsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormController.CloseReportsForm(e);

        }

        private void btnDeleteReport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (EmployeeDbContext db = new EmployeeDbContext())
                {
                    var entry = db.Entry(reportsModel);
                    if (entry.State == EntityState.Detached)
                    {
                        db.ReportsModel.Attach(reportsModel);
                        db.ReportsModel.Remove(reportsModel);
                        db.SaveChanges();
                        LoadData();
                        MessageBox.Show("Deleted Successfully", "Delete Success");
                    }
                }
            }
        }

        private void dgvReports_DoubleClick(object sender, EventArgs e)
        {
            if (dgvReports.CurrentRow.Index != -1)
            {
                reportsModel.ReportId = Convert.ToInt32(dgvReports.CurrentRow.Cells["dgReportId"].Value);
                using (EmployeeDbContext db = new EmployeeDbContext())
                {
                    reportsModel = db.ReportsModel.Where(x => x.ReportId == reportsModel.ReportId).FirstOrDefault();
                }
                btnDeleteReport.Enabled = true;
                btnPostReport.Enabled = true;
            }
        }

        private void btnPostReport_Click(object sender, EventArgs e)
        {
            using (EmployeeDbContext db = new EmployeeDbContext())
            {
                newsModel.NewsReport = string.Concat(reportsModel.ReportName, " by ", reportsModel.InCharge, " on ", reportsModel.DateFinished);

                db.NewsModel.Add(newsModel);
                db.ReportsModel.Remove(reportsModel);
                MessageBox.Show("Submitted Successfully", "Adding Success");

                db.SaveChanges();
            }

            LoadData();
        }
    }
}
