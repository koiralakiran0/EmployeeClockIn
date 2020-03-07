using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClockIn
{
    public partial class AddEmployee : Form
    {
        private Thread thread;
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
            Boolean adminStatus = checkBoxAdminStatus.Checked;
            Employee employee = new Employee(firstName, lastName, userName, password, loginID, false, adminStatus);
            EmployeeController.addEmployee(employee);

            thread = new Thread(openAdminForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void openAdminForm()
        {
            Application.Run(new AdminForm());
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
