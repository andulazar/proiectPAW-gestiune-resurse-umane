namespace proiectPAW_gestiune_resurse_umane
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewEmployees
            // 
            this.listViewEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCNP,
            this.colJob,
            this.colSalary});
            this.listViewEmployees.FullRowSelect = true;
            this.listViewEmployees.HideSelection = false;
            this.listViewEmployees.Location = new System.Drawing.Point(47, 64);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(1056, 369);
            this.listViewEmployees.TabIndex = 0;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            this.listViewEmployees.View = System.Windows.Forms.View.Details;
            this.listViewEmployees.SelectedIndexChanged += new System.EventHandler(this.listViewEmployees_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            // 
            // colCNP
            // 
            this.colCNP.Text = "CNP";
            // 
            // colJob
            // 
            this.colJob.Text = "Job";
            // 
            // colSalary
            // 
            this.colSalary.Text = "Salary";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(518, 477);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(95, 30);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 553);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.listViewEmployees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmployees;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCNP;
        private System.Windows.Forms.ColumnHeader colJob;
        private System.Windows.Forms.ColumnHeader colSalary;
        private System.Windows.Forms.Button btnAddEmployee;
    }
}