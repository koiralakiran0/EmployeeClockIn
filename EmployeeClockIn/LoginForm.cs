using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.IO;

namespace EmployeeClockIn
{
    public partial class LoginForm : Form
    {
        Thread thread;

        public LoginForm()
        {
            InitializeComponent();
            EmployeeController.loadEmployees();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            if (EmployeeController.isValidEmployee(username, password)) 
            {
                if (EmployeeController.getEmployees()[username].getAdminStatus())
                {
                    thread = new Thread(openAdminForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    this.Close();
                }
                else
                {
                    EmployeeController.setCurrentEmployee(EmployeeController.getEmployees()[username]);
                    thread = new Thread(openUserForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    this.Close();
                }
            } else
            {
                WrongLoginInfoLabel.Show();
            }
        }


        private void openUserForm()
        {
            Application.Run(new UserForm());
        }

        private void openAdminForm()
        {
            Application.Run(new AdminForm());
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
