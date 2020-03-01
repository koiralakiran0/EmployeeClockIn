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
            //EmployeeController.
            dataWrite("clockIn");
        }

        private void buttonClockOut_Click(object sender, EventArgs e)
        {
            buttoncheckin.Visible = true;
            labelClockedOut.Visible = true;
            buttonClockOut.Visible = false;
            labelClockedIn.Visible = false;
        }

        private void dataWrite(string v)
        {
            Employee emp = EmployeeController.getCurrentEmployee();
            String path = @"C:/temp/clockInData/" + emp.getUserName() + "/data.csv";
            if (!File.Exists(path))
            {
                FileInfo fileInfo = new FileInfo(path);
                fileInfo.Directory.Create();
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(emp.getUserName() + "," + v);
                }
            }
            else if (File.Exists(path))
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(emp.getUserName() + "," + v);
                }
            }
            
        }
    }
}
