using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClockIn
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            if (EmployeeController.getCurrentEmployee().getClockedInStatus())
            {
                buttoncheckin.Visible = true;
                labelClockedOut.Visible = true;
                buttonClockOut.Visible = false;
                labelClockedIn.Visible = false;
            }
            else
            {
                buttonClockOut.Visible = true;
                labelClockedIn.Visible = true;
                buttoncheckin.Visible = false;
                labelClockedOut.Visible = false;
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void buttoncheckin_Click(object sender, EventArgs e)
        {
            buttonClockOut.Visible = true;
            labelClockedIn.Visible = true;
            buttoncheckin.Visible = false;
            labelClockedOut.Visible = false;
            EmployeeController.writeUserData("clockIn");
        }

        private void buttonClockOut_Click(object sender, EventArgs e)
        {
            buttoncheckin.Visible = true;
            labelClockedOut.Visible = true;
            buttonClockOut.Visible = false;
            labelClockedIn.Visible = false;
            EmployeeController.writeUserData("clockOut");
        }
    }
}
