using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proiectPAW_gestiune_resurse_umane
{
    public partial class Form1 : Form
    {
        private readonly List<employee> employees = new List<employee>();
        private bool sortDescending = false;

        public Form1()
        {
            InitializeComponent();
            UpdateButtons();
        }

        private void RefreshList()
        {
            listViewEmployees.BeginUpdate();
            listViewEmployees.Items.Clear();

            foreach (employee emp in employees)
            {
                ListViewItem row = new ListViewItem(emp.fullName);
                row.SubItems.Add(emp.cNP);
                row.SubItems.Add(emp.birthDate.ToShortDateString());

                if (emp.myjob != null)
                {
                    row.SubItems.Add(emp.myjob.jobName);
                    row.SubItems.Add(emp.myjob.salary.ToString("N2"));
                }
                else
                {
                    row.SubItems.Add("-");
                    row.SubItems.Add("-");
                }

                row.SubItems.Add(emp.coursesCompleted.Count.ToString());
                row.Tag = emp;
                listViewEmployees.Items.Add(row);
            }

            listViewEmployees.EndUpdate();
            lblCount.Text = $"Total employees: {employees.Count}";
            UpdateButtons();
        }

        private employee SelectedEmployee()
        {
            if (listViewEmployees.SelectedItems.Count == 0) return null;
            return listViewEmployees.SelectedItems[0].Tag as employee;
        }

        private void UpdateButtons()
        {
            bool hasSelection = listViewEmployees.SelectedItems.Count > 0;
            btnEditEmployee.Enabled = hasSelection;
            btnDeleteEmployee.Enabled = hasSelection;
            btnSortBySalary.Enabled = employees.Count > 1;
        }

        private bool CnpExists(string cnp, employee except)
        {
            foreach (employee emp in employees)
            {
                if (!ReferenceEquals(emp, except) && emp.cNP == cnp) return true;
            }
            return false;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            employee newEmployee = new employee();

            using (Formemployee secondaryForm = new Formemployee(newEmployee, false))
            {
                if (secondaryForm.ShowDialog() != DialogResult.OK) return;
            }

            if (CnpExists(newEmployee.cNP, null))
            {
                MessageBox.Show("An employee with this CNP already exists!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            employees.Add(newEmployee);
            RefreshList();
        }

        private void EditSelectedEmployee()
        {
            employee original = SelectedEmployee();
            if (original == null) return;

            // Work on a copy so that "Cancel" discards every change (including courses).
            employee copy = (employee)original.Clone();

            using (Formemployee secondaryForm = new Formemployee(copy, true))
            {
                if (secondaryForm.ShowDialog() != DialogResult.OK) return;
            }

            if (CnpExists(copy.cNP, original))
            {
                MessageBox.Show("An employee with this CNP already exists!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = employees.IndexOf(original);
            employees[index] = copy;
            RefreshList();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            EditSelectedEmployee();
        }

        private void listViewEmployees_DoubleClick(object sender, EventArgs e)
        {
            EditSelectedEmployee();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            employee selected = SelectedEmployee();
            if (selected == null) return;

            DialogResult answer = MessageBox.Show(
                $"Are you sure you want to delete {selected.fullName}?",
                "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                employees.Remove(selected);
                RefreshList();
            }
        }

        private void btnSortBySalary_Click(object sender, EventArgs e)
        {
            // Uses employee.CompareTo (IComparable<employee>) - sorts by salary.
            employees.Sort();
            if (sortDescending) employees.Reverse();
            btnSortBySalary.Text = sortDescending ? "Sort by salary ▲" : "Sort by salary ▼";
            sortDescending = !sortDescending;
            RefreshList();
        }

        private void listViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void listViewEmployees_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) btnDeleteEmployee_Click(sender, e);
            else if (e.KeyCode == Keys.Enter) EditSelectedEmployee();
        }
    }
}
