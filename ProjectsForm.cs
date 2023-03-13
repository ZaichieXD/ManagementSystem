using ManagementSystem.Configurations;
using ManagementSystem.DataModels;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Scripts;

namespace ManagementSystem
{
    public partial class ProjectsForm : Form
    {
        Projects projectsModel = new Projects();
        Reports reportsModel = new Reports();

        public ProjectsForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtProjName.Text = txtDescription.Text = "";
            txtPosition.SelectedItem = txtEmployees.SelectedItem = "";
            txtStartDate.Value = DateTime.Now;
            txtEndDate.Value = DateTime.Now;
            taskFinished.Checked = false;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        private void ProjectsForm_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = txtProjName;
            LoadData();
            txtEmployees.Enabled = false;
            taskFinished.Enabled = false;
            
        }

        private void GetEmployeeData(string? selectedValue)
        {
            txtEmployees.Items.Clear();

            using (EmployeeDbContext db = new EmployeeDbContext())
            {
                List<Employee> employees = db.EmployeeModel.ToList<Employee>();

                foreach (var item in employees.Where(x => x.Position == selectedValue).ToList())
                {
                    txtEmployees.Items.Add(item.FirstName + " " + item.LastName);
                }
            }
        }

        private void LoadData()
        {
            dgvProjects.AutoGenerateColumns = false;
            using (EmployeeDbContext db = new EmployeeDbContext())
            {
                dgvProjects.DataSource = db.ProjectsModel.ToList<Projects>();
            }
        }

        private void txtPosition_SelectedValueChanged(object sender, EventArgs e)
        {
            GetEmployeeData(txtPosition.SelectedItem.ToString());
            txtEmployees.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            projectsModel.ProjectName = txtProjName.Text.Trim();
            projectsModel.ProjectDescription = txtDescription.Text.Trim();
            projectsModel.Position = txtPosition.SelectedItem.ToString().Trim();
            projectsModel.InCharge = txtEmployees.SelectedItem.ToString().Trim();
            projectsModel.StartDate = txtStartDate.Value;
            projectsModel.EstimatedEndDate = txtEndDate.Value;
            projectsModel.Finished = taskFinished.Checked;

            using (EmployeeDbContext db = new EmployeeDbContext())
            {
                if (projectsModel.ProjectId == 0)
                {
                    db.ProjectsModel.Add(projectsModel);
                }
                else
                {
                    db.Entry(projectsModel).State = EntityState.Modified;

                    if (projectsModel.Finished == true)
                    {
                        reportsModel.ReportName = string.Concat(projectsModel.ProjectName, " - Done");
                        reportsModel.DateFinished = DateTime.Now;
                        reportsModel.InCharge = projectsModel.InCharge;

                        db.ReportsModel.Add(reportsModel);
                        db.ProjectsModel.Remove(projectsModel);
                    }
                }

                db.SaveChanges();
            }
            Clear();
            LoadData();
            MessageBox.Show("Submitted Successfully", "Adding Success");
        }

        private void dgvProjects_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProjects.CurrentRow.Index != -1)
            {
                projectsModel.ProjectId = Convert.ToInt32(dgvProjects.CurrentRow.Cells["dgProjectId"].Value);
                using (EmployeeDbContext db = new EmployeeDbContext())
                {
                    projectsModel = db.ProjectsModel.Where(x => x.ProjectId == projectsModel.ProjectId).FirstOrDefault();

                    txtProjName.Text = projectsModel.ProjectName;
                    txtDescription.Text = projectsModel.ProjectDescription;
                    txtPosition.SelectedItem = projectsModel.Position;
                    txtEmployees.SelectedItem = projectsModel.InCharge;
                    txtStartDate.Value = projectsModel.StartDate;
                    txtEndDate.Value = projectsModel.EstimatedEndDate;
                    taskFinished.Checked = projectsModel.Finished;
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                taskFinished.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (EmployeeDbContext db = new EmployeeDbContext())
                {
                    var entry = db.Entry(projectsModel);
                    if (entry.State == EntityState.Detached)
                    {
                        db.ProjectsModel.Attach(projectsModel);
                        db.ProjectsModel.Remove(projectsModel);
                        db.SaveChanges();
                        LoadData();
                        Clear();
                        MessageBox.Show("Deleted Successfully", "Delete Success");
                    }
                }
            }
        }

        private void ProjectsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                FormController.CloseProjectsForm(e);
            }
        }
    }
}
