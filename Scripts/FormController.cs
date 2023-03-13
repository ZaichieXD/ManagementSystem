
namespace ManagementSystem.Scripts
{
    public static class FormController
    {
        private static ProjectsForm projectsForm = new ProjectsForm();
        private static EmployeeForm employeeForm = new EmployeeForm();
        private static ReportsForm reportsForm = new ReportsForm();
        private static HomeForm homeForm = new HomeForm();

        public static void CloseProjectsForm(FormClosingEventArgs e)
        {
            projectsForm.Hide();
            projectsForm.Parent = null;
            e.Cancel = true;
            homeForm.Show();
        }

        public static void CloseEmployeeForm(FormClosingEventArgs e)
        {
            employeeForm.Hide();
            employeeForm.Parent = null;
            e.Cancel = true;
            homeForm.Show();
        }

        public static void CloseReportsForm(FormClosingEventArgs e)
        {
            reportsForm.Hide();
            reportsForm.Parent = null;
            e.Cancel = true;
            homeForm.Show();
        }

        public static void OpenReportsForm()
        {
            reportsForm.Show();
            homeForm.Hide();
        }

        public static void OpenProjectsForm()
        {
            projectsForm.Show();
            homeForm.Hide();
        }

        public static void OpenEmployeeForm()
        {
            employeeForm.Show();
            homeForm.Hide();
        }

        public static void RunHomeForm()
        {
            Application.Run(homeForm);
        }
    }
}
