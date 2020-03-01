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
            this.labelClockedIn = new System.Windows.Forms.Label();
            this.labelClockedOut = new System.Windows.Forms.Label();
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
            this.buttoncheckin.Click += new System.EventHandler(this.buttoncheckin_Click);
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
            this.buttonClockOut.Click += new System.EventHandler(this.buttonClockOut_Click);
            // 
            // labelClockedIn
            // 
            this.labelClockedIn.AutoSize = true;
            this.labelClockedIn.Location = new System.Drawing.Point(361, 381);
            this.labelClockedIn.Name = "labelClockedIn";
            this.labelClockedIn.Size = new System.Drawing.Size(58, 13);
            this.labelClockedIn.TabIndex = 2;
            this.labelClockedIn.Text = "Clocked In";
            this.labelClockedIn.Visible = false;
            // 
            // labelClockedOut
            // 
            this.labelClockedOut.AutoSize = true;
            this.labelClockedOut.Location = new System.Drawing.Point(353, 406);
            this.labelClockedOut.Name = "labelClockedOut";
            this.labelClockedOut.Size = new System.Drawing.Size(66, 13);
            this.labelClockedOut.TabIndex = 3;
            this.labelClockedOut.Text = "Clocked Out";
            this.labelClockedOut.Visible = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelClockedOut);
            this.Controls.Add(this.labelClockedIn);
            this.Controls.Add(this.buttonClockOut);
            this.Controls.Add(this.buttoncheckin);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoncheckin;
        private System.Windows.Forms.Button buttonClockOut;
        private System.Windows.Forms.Label labelClockedIn;
        private System.Windows.Forms.Label labelClockedOut;
    }
}