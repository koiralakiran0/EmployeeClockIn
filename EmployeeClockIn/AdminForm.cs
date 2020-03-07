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
            this.Close();
        }

        private void openNewEmployeeForm()
        {
            Application.Run(new AddEmployee());
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Dictionary<String, Employee> dictionary = EmployeeController.getEmployees();

            foreach (Employee emp in dictionary.Values)
            {
                ListViewItem item = new ListViewItem(emp.getFirstName() + " " + emp.getLastName());
                item.SubItems.Add(emp.getUserName());
                item.SubItems.Add(emp.getLoginID());
                item.SubItems.Add(emp.getPassword());
                item.SubItems.Add(emp.getClockedInStatus().ToString());
                item.SubItems.Add(emp.getAdminStatus().ToString());
                listViewEmployees.Items.Add(item);
            }
        }
    }
}
