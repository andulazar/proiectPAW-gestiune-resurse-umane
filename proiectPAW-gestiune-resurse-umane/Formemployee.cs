using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace proiectPAW_gestiune_resurse_umane
{
    public partial class Formemployee : Form
    {
        private static int nextJobId = 1;

        private readonly employee localEmployee;

        public Formemployee() : this(new employee(), false)
        {
        }

        public Formemployee(employee _localEmployee, bool modificare = false)
        {
            InitializeComponent();
            localEmployee = _localEmployee;
            dtpBirthDate.MaxDate = DateTime.Today;

            if (modificare)
            {
                Text = "Edit employee";
                tbFullName.Text = localEmployee.fullName;
                tbCnp.Text = localEmployee.cNP;
                if (localEmployee.birthDate >= dtpBirthDate.MinDate && localEmployee.birthDate <= dtpBirthDate.MaxDate)
                    dtpBirthDate.Value = localEmployee.birthDate;

                if (localEmployee.myjob != null)
                {
                    tbJobName.Text = localEmployee.myjob.jobName;
                    tbSalary.Text = localEmployee.myjob.salary.ToString(CultureInfo.CurrentCulture);
                }
            }
            else
            {
                Text = "Add employee";
                dtpBirthDate.Value = DateTime.Today.AddYears(-18);
            }

            RefreshCourses();
        }

        private void RefreshCourses()
        {
            listBoxCourses.Items.Clear();
            foreach (course c in localEmployee.coursesCompleted)
            {
                listBoxCourses.Items.Add(c);
            }
            btnRemoveCourse.Enabled = listBoxCourses.SelectedIndex >= 0;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string numeCurs = tbCourseName.Text.Trim();
            if (string.IsNullOrWhiteSpace(numeCurs))
            {
                MessageBox.Show("Please enter the course name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCourseName.Focus();
                return;
            }

            if (!int.TryParse(tbCourseHours.Text.Trim(), out int oreCurs) || oreCurs <= 0)
            {
                MessageBox.Show("The number of hours must be a positive whole number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCourseHours.Focus();
                return;
            }

            int newId = localEmployee.coursesCompleted.Count == 0
                ? 1
                : localEmployee.coursesCompleted.Max(c => c.courseId) + 1;

            localEmployee.coursesCompleted.Add(new course(numeCurs, oreCurs, newId));
            RefreshCourses();

            tbCourseName.Clear();
            tbCourseHours.Clear();
            tbCourseName.Focus();
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            if (listBoxCourses.SelectedItem is course selected)
            {
                localEmployee.coursesCompleted.Remove(selected);
                RefreshCourses();
            }
        }

        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveCourse.Enabled = listBoxCourses.SelectedIndex >= 0;
        }

        private static bool IsValidCnp(string cnp)
        {
            return cnp.Length == 13 && cnp.All(char.IsDigit);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = tbFullName.Text.Trim();
            string cnp = tbCnp.Text.Trim();
            string jobName = tbJobName.Text.Trim();
            string salaryText = tbSalary.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Please enter the full name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbFullName.Focus();
                return;
            }

            if (!IsValidCnp(cnp))
            {
                MessageBox.Show("The CNP must contain exactly 13 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCnp.Focus();
                return;
            }

            job newJob = null;
            if (jobName.Length > 0 || salaryText.Length > 0)
            {
                if (jobName.Length == 0)
                {
                    MessageBox.Show("Please enter the job name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbJobName.Focus();
                    return;
                }

                if (!double.TryParse(salaryText, NumberStyles.Number, CultureInfo.CurrentCulture, out double salariu) || salariu <= 0)
                {
                    MessageBox.Show("The salary must be a positive number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbSalary.Focus();
                    return;
                }

                int jobId = localEmployee.myjob != null ? localEmployee.myjob.jobId : nextJobId++;
                newJob = new job(jobName, salariu, jobId);
            }

            localEmployee.fullName = fullName;
            localEmployee.cNP = cnp;
            localEmployee.birthDate = dtpBirthDate.Value.Date;
            localEmployee.myjob = newJob;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
