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
    public partial class AdminForm : Form
    {
        private Thread thread;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void buttonAddNewEmployee_Click(object sender, EventArgs e)
        {
            thread = new Thread(openNewEmployeeForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openNewEmployeeForm()
        {
            Application.Run(new AddEmployee());
        }

        private void listViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
