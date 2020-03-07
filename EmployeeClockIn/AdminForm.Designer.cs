using System;

namespace EmployeeClockIn
{
    partial class AdminForm
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
            this.buttonAddNewEmployee = new System.Windows.Forms.Button();
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.Employees = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loginID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isClockedIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adminStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonAddNewEmployee
            // 
            this.buttonAddNewEmployee.Location = new System.Drawing.Point(354, 311);
            this.buttonAddNewEmployee.Name = "buttonAddNewEmployee";
            this.buttonAddNewEmployee.Size = new System.Drawing.Size(133, 23);
            this.buttonAddNewEmployee.TabIndex = 0;
            this.buttonAddNewEmployee.Text = "Add New Employee";
            this.buttonAddNewEmployee.UseVisualStyleBackColor = true;
            this.buttonAddNewEmployee.Click += new System.EventHandler(this.buttonAddNewEmployee_Click);
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(493, 311);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(133, 23);
            this.buttonRemoveEmployee.TabIndex = 1;
            this.buttonRemoveEmployee.Text = "Remove Employee";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // listViewEmployees
            // 
            this.listViewEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Employees,
            this.userName,
            this.loginID,
            this.password,
            this.isClockedIn,
            this.adminStatus});
            this.listViewEmployees.HideSelection = false;
            this.listViewEmployees.Location = new System.Drawing.Point(2, 12);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(621, 293);
            this.listViewEmployees.TabIndex = 2;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            this.listViewEmployees.View = System.Windows.Forms.View.Details;
            this.listViewEmployees.SelectedIndexChanged += new System.EventHandler(this.listViewEmployees_SelectedIndexChanged);
            // 
            // Employees
            // 
            this.Employees.Text = "Employee";
            this.Employees.Width = 93;
            // 
            // userName
            // 
            this.userName.Text = "User Name";
            this.userName.Width = 96;
            // 
            // loginID
            // 
            this.loginID.Text = "Login ID";
            this.loginID.Width = 91;
            // 
            // password
            // 
            this.password.Text = "Password";
            this.password.Width = 82;
            // 
            // isClockedIn
            // 
            this.isClockedIn.Text = "ClockedInStatus";
            this.isClockedIn.Width = 102;
            // 
            // adminStatus
            // 
            this.adminStatus.Text = "Admin Status";
            this.adminStatus.Width = 96;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 345);
            this.Controls.Add(this.listViewEmployees);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.buttonAddNewEmployee);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        private void listViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewEmployee;
        private System.Windows.Forms.Button buttonRemoveEmployee;
        private System.Windows.Forms.ListView listViewEmployees;
        private System.Windows.Forms.ColumnHeader Employees;
        private System.Windows.Forms.ColumnHeader userName;
        private System.Windows.Forms.ColumnHeader loginID;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.ColumnHeader isClockedIn;
        private System.Windows.Forms.ColumnHeader adminStatus;
    }
}