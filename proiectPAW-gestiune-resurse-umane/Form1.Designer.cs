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
            this.colBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCourses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnSortBySalary = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // listViewEmployees
            //
            this.listViewEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCNP,
            this.colBirthDate,
            this.colJob,
            this.colSalary,
            this.colCourses});
            this.listViewEmployees.FullRowSelect = true;
            this.listViewEmployees.GridLines = true;
            this.listViewEmployees.HideSelection = false;
            this.listViewEmployees.Location = new System.Drawing.Point(47, 64);
            this.listViewEmployees.MultiSelect = false;
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(1056, 369);
            this.listViewEmployees.TabIndex = 0;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            this.listViewEmployees.View = System.Windows.Forms.View.Details;
            this.listViewEmployees.SelectedIndexChanged += new System.EventHandler(this.listViewEmployees_SelectedIndexChanged);
            this.listViewEmployees.DoubleClick += new System.EventHandler(this.listViewEmployees_DoubleClick);
            this.listViewEmployees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewEmployees_KeyDown);
            //
            // colName
            //
            this.colName.Text = "Name";
            this.colName.Width = 250;
            //
            // colCNP
            //
            this.colCNP.Text = "CNP";
            this.colCNP.Width = 140;
            //
            // colBirthDate
            //
            this.colBirthDate.Text = "Date of birth";
            this.colBirthDate.Width = 110;
            //
            // colJob
            //
            this.colJob.Text = "Job";
            this.colJob.Width = 250;
            //
            // colSalary
            //
            this.colSalary.Text = "Salary (RON)";
            this.colSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSalary.Width = 120;
            //
            // colCourses
            //
            this.colCourses.Text = "Courses";
            this.colCourses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colCourses.Width = 80;
            //
            // btnAddEmployee
            //
            this.btnAddEmployee.Location = new System.Drawing.Point(47, 460);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(130, 34);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            //
            // btnEditEmployee
            //
            this.btnEditEmployee.Location = new System.Drawing.Point(193, 460);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(130, 34);
            this.btnEditEmployee.TabIndex = 2;
            this.btnEditEmployee.Text = "Edit employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            //
            // btnDeleteEmployee
            //
            this.btnDeleteEmployee.Location = new System.Drawing.Point(339, 460);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(130, 34);
            this.btnDeleteEmployee.TabIndex = 3;
            this.btnDeleteEmployee.Text = "Delete employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            //
            // btnSortBySalary
            //
            this.btnSortBySalary.Location = new System.Drawing.Point(485, 460);
            this.btnSortBySalary.Name = "btnSortBySalary";
            this.btnSortBySalary.Size = new System.Drawing.Size(130, 34);
            this.btnSortBySalary.TabIndex = 4;
            this.btnSortBySalary.Text = "Sort by salary ▲";
            this.btnSortBySalary.UseVisualStyleBackColor = true;
            this.btnSortBySalary.Click += new System.EventHandler(this.btnSortBySalary_Click);
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(43, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 24);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Employees";
            //
            // lblCount
            //
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(990, 470);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(100, 13);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "Total employees: 0";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 553);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSortBySalary);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.listViewEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human Resources Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmployees;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCNP;
        private System.Windows.Forms.ColumnHeader colBirthDate;
        private System.Windows.Forms.ColumnHeader colJob;
        private System.Windows.Forms.ColumnHeader colSalary;
        private System.Windows.Forms.ColumnHeader colCourses;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnSortBySalary;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCount;
    }
}
