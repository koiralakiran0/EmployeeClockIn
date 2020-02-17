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
            this.SuspendLayout();
            // 
            // buttonAddNewEmployee
            // 
            this.buttonAddNewEmployee.Location = new System.Drawing.Point(581, 459);
            this.buttonAddNewEmployee.Name = "buttonAddNewEmployee";
            this.buttonAddNewEmployee.Size = new System.Drawing.Size(133, 23);
            this.buttonAddNewEmployee.TabIndex = 0;
            this.buttonAddNewEmployee.Text = "Add New Employee";
            this.buttonAddNewEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(734, 459);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(133, 23);
            this.buttonRemoveEmployee.TabIndex = 1;
            this.buttonRemoveEmployee.Text = "Remove Employee";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 513);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.buttonAddNewEmployee);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewEmployee;
        private System.Windows.Forms.Button buttonRemoveEmployee;
    }
}