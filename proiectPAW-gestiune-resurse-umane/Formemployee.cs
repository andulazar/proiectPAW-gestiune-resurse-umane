using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPAW_gestiune_resurse_umane
{
    public partial class Formemployee : Form
    {
        employee localEmployee;
        public Formemployee()
        {
            InitializeComponent();
            localEmployee = new employee();
        }
        public Formemployee(employee _localEmployee, bool modificare = false)
        {
            InitializeComponent();
            localEmployee = _localEmployee;

            if (modificare)
            {
                tbFullName.Text = localEmployee.fullName;
                tbCnp.Text = localEmployee.cNP;
                dtpBirthDate.Value = localEmployee.birthDate;

                if (localEmployee.myjob != null)
                {
                    tbJobName.Text = localEmployee.myjob.jobName;
                    tbSalary.Text = localEmployee.myjob.salary.ToString();
                }

                if (localEmployee.coursesCompleted != null)
                {
                    foreach (course c in localEmployee.coursesCompleted)
                    {
                        listBoxCourses.Items.Add($"{c.courseName} - {c.numberOfhours} ore");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                string numeCurs = tbCourseName.Text;
                int oreCurs = int.Parse(tbCourseHours.Text);

                if (string.IsNullOrWhiteSpace(numeCurs))
                {
                    MessageBox.Show("Te rog introdu numele cursului!");
                    return; 
                }

                course cursNou = new course(numeCurs, oreCurs, 100);

                localEmployee.coursesCompleted.Add(cursNou);

                listBoxCourses.Items.Add($"{cursNou.courseName} - {cursNou.numberOfhours} ore");

                tbCourseName.Clear();
                tbCourseHours.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Numărul de ore trebuie să fie un număr valid!", "Eroare");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                localEmployee.fullName = tbFullName.Text;
                localEmployee.cNP = tbCnp.Text;
                localEmployee.birthDate = dtpBirthDate.Value;

                double salariu = double.Parse(tbSalary.Text);
                localEmployee.myjob = new job(tbJobName.Text, salariu, 1);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Te rog verifică datele introduse. Salariul trebuie să fie valid.\n" + ex.Message, "Eroare");
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
