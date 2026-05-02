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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            employee newEmployee = new employee();

            
            Formemployee secondaryForm = new Formemployee(newEmployee, false);

            if (secondaryForm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem newRow = new ListViewItem(newEmployee.fullName); 
                newRow.SubItems.Add(newEmployee.cNP);                         

                if (newEmployee.myjob != null)
                {
                    newRow.SubItems.Add(newEmployee.myjob.jobName);          
                    newRow.SubItems.Add(newEmployee.myjob.salary.ToString()); 
                }
                else
                {
                    newRow.SubItems.Add("-");
                    newRow.SubItems.Add("-");
                }

                
                newRow.Tag = newEmployee;

                listViewEmployees.Items.Add(newRow);
            }
        }

        private void listViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}