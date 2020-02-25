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
using System.Data;
using System.IO;

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
            Dictionary<String, String> users = new Dictionary<string, string>();
            populateDictionary(users);

            if (users.ContainsKey(username) && users[username].Equals(password)) 
            {
                if (username == "koiralakiran0")
                {
                    thread = new Thread(openAdminForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    this.Close();
                }
                else
                {
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

        

        private void populateDictionary(Dictionary<string, string> users)
        {
            var path = Path.Combine("C:\\temp\\Users.txt");
            using (StreamReader file = new StreamReader(path))
            {
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    string[] str = ln.Split(',');
                    users.Add(str[0], str[1]);
                }
                file.Close();
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
