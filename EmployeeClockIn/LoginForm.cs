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

namespace EmployeeClockIn
{
    public partial class LoginForm : Form
    {
        String username;
        String password;
        Thread thread;

        public LoginForm()
        {
            InitializeComponent();
            username = password = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;

            if (textBoxUsername.Text == "kkoiral")
            {
                thread = new Thread(openUserForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }
        }

        private void openUserForm()
        {
            Application.Run(new UserForm());
        }
    }
}
