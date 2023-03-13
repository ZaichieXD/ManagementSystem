using ManagementSystem.Configurations;
using ManagementSystem.DataModels;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Scripts;

namespace ManagementSystem
{
    public partial class EmployeeForm : Form
    {
        Employee employeeModel = new Employee();

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtEmail.Text = txtPassword.Text = txtAddress.Text = "";
            txtPosition.SelectedItem = "";
            saveBtn.Text = "Save";
            deleteBtn.Enabled = false;
            employeeModel.EmployeeId = 0;
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                FormController.CloseEmployeeForm(e);
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = txtFirstName;
            LoadData();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            employeeModel.FirstName = txtFirstName.Text.Trim();
            employeeModel.LastName = txtLastName.Text.Trim();
            employeeModel.Position = txtPosition.SelectedItem.ToString();
            employeeModel.Email = txtEmail.Text.Trim();
            employeeModel.Password = txtPassword.Text.Trim();
            employeeModel.Address = txtAddress.Text.Trim();

            using (EmployeeDbContext db = new EmployeeDbContext())
            {
                if (employeeModel.EmployeeId == 0)
                {
                    db.EmployeeModel.Add(employeeModel);
                }
                else
                {
                    db.Entry(employeeModel).State = EntityState.Modified;
                }

                db.SaveChanges();
            }
            Clear();
            LoadData();
            MessageBox.Show("Submitted Successfully", "Adding Success");
        }

        private void LoadData()
        {
            dgvEmployees.AutoGenerateColumns = false;
            using (EmployeeDbContext db = new EmployeeDbContext())
            {
                dgvEmployees.DataSource = db.EmployeeModel.ToList<Employee>();
            }
        }

        private void dgvEmployees_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow.Index != -1)
            {
                employeeModel.EmployeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["dgEmployeeId"].Value);
                using (EmployeeDbContext db = new EmployeeDbContext())
                {
                    employeeModel = db.EmployeeModel.Where(x => x.EmployeeId == employeeModel.EmployeeId).FirstOrDefault();

                    txtFirstName.Text = employeeModel.FirstName;
                    txtLastName.Text = employeeModel.LastName;
                    txtPosition.SelectedItem = employeeModel.Position;
                    txtEmail.Text = employeeModel.Email;
                    txtPassword.Text = employeeModel.Password;
                    txtAddress.Text = employeeModel.Address;
                }
                saveBtn.Text = "Update";
                deleteBtn.Enabled = true;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (EmployeeDbContext db = new EmployeeDbContext())
                {
                    var entry = db.Entry(employeeModel);
                    if (entry.State == EntityState.Detached)
                    {
                        db.EmployeeModel.Attach(employeeModel);
                        db.EmployeeModel.Remove(employeeModel);
                        db.SaveChanges();
                        LoadData();
                        Clear();
                        MessageBox.Show("Deleted Successfully", "Delete Success");
                    }
                }
            }
        }
    }
}