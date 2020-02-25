namespace EmployeeClockIn
{
    partial class UserForm
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
            this.buttoncheckin = new System.Windows.Forms.Button();
            this.buttonClockOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttoncheckin
            // 
            this.buttoncheckin.Location = new System.Drawing.Point(278, 85);
            this.buttoncheckin.Name = "buttoncheckin";
            this.buttoncheckin.Size = new System.Drawing.Size(232, 117);
            this.buttoncheckin.TabIndex = 0;
            this.buttoncheckin.Text = "Clock In";
            this.buttoncheckin.UseVisualStyleBackColor = true;
            // 
            // buttonClockOut
            // 
            this.buttonClockOut.Location = new System.Drawing.Point(278, 242);
            this.buttonClockOut.Name = "buttonClockOut";
            this.buttonClockOut.Size = new System.Drawing.Size(232, 117);
            this.buttonClockOut.TabIndex = 1;
            this.buttonClockOut.Text = "Clock Out";
            this.buttonClockOut.UseVisualStyleBackColor = true;
            this.buttonClockOut.Visible = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClockOut);
            this.Controls.Add(this.buttoncheckin);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttoncheckin;
        private System.Windows.Forms.Button buttonClockOut;
    }
}