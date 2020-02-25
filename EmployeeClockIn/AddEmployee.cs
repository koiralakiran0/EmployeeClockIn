using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClockIn
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstName = textBoxFirstName.Text;
            String lastName = textBoxLastName.Text;
            String userName = textBoxUserName.Text;
            String password = textBoxPassword.Text;
            String loginID = textBoxLoginID.Text;
            Boolean clockedInStatus = checkBoxClockedInStatus.Checked;
            Boolean adminStatus = checkBoxAdminStatus.Checked;
            Employee employee = new Employee(firstName, lastName, userName, password, loginID, clockedInStatus, adminStatus);
        }
    }
}
