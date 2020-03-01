using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClockIn
{
    class EmployeeController
    {
        private static Dictionary<String, Employee> users = new Dictionary<string, Employee>();
        private static Employee currentEmployee;

        public static void loadEmployees()
        {
            users.Add("koiralakiran0", new Employee("Kiran", "Koirala", "koiralakiran0","12345","koiralakiran0",false, true));
            users.Add("kkoiral", new Employee("Kiran", "Koirala", "kkoiral", "12345", "kkoiral", false, false));
            users.Add("koiralakiran", new Employee("Kiran", "Koirala", "koiralakiran", "12345", "koiralakiran", false, false));
            users.Add("dchamlagai", new Employee("Durga", "Chamlagai", "dchamlagai", "12345", "dchamlagai", false, true));
            users.Add("rcp1", new Employee("Ram", "Phuyel", "rcp1", "12345", "rcp1", false, true));

            /*
            var path = Path.Combine("C:\\temp\\users.txt");
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
            */
        }

        public static void addEmployee(Employee emp)
        {
            users.Add(emp.getUserName(), emp);
        }

        public static void markdownClockIn()
        {

        }

        public static Dictionary<String, Employee> getEmployees()
        {
            return users;
        }

        public static Boolean isValidEmployee(String username, String password)
        {
            if (users.ContainsKey(username) && users[username].getPassword() == password)
            {
                currentEmployee = users[username];
                return true;
            }
            return false;
        }

        public static Employee getCurrentEmployee()
        {
            return currentEmployee;
        }

        public static void setCurrentEmployee(Employee employee)
        {
            currentEmployee = employee;
        }
    }
}
