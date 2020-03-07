using System;
using System.Collections.Generic;
using System.IO;
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
            users.Add("koiralakiran0", new Employee("Kiran", "Koirala", "koiralakiran0", "12345", "koiralakiran0", false, true));

            String path = @"C:/temp/clockInData/employeeInfo.csv";
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    String line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        String[] str = line.Split(',');
                        users.Add(str[2], new Employee(str[0], str[1], str[2], str[3], str[4], Boolean.Parse(str[5]), Boolean.Parse(str[6])));
                    }
                }
            }
            else if (!File.Exists(path))
            {
                FileInfo fileInfo = new FileInfo(path);
                fileInfo.Directory.Create();
            }
        }

        public static void writeUserData(String status)
        {
            Employee emp = EmployeeController.getCurrentEmployee();
            String path = @"C:/temp/clockInData/" + emp.getUserName() + "/data.csv";
            if (!File.Exists(path))
            {
                FileInfo fileInfo = new FileInfo(path);
                fileInfo.Directory.Create();
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(emp.getUserName() + "," + status + "," + DateTime.Now.ToString());
                }
            }
            else if (File.Exists(path))
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(emp.getUserName() + "," + status + "," + DateTime.Now.ToString());
                }
            }
        }

        public static void addEmployee(Employee emp)
        {
            users.Add(emp.getUserName(), emp);
            String path = @"C:/temp/clockInData/employeeInfo.csv";
            if (File.Exists(path))
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(emp.getFirstName() + "," +
                        emp.getLastName() + "," +
                        emp.getUserName() + "," +
                        emp.getPassword() + "," +
                        emp.getLoginID() + "," +
                        emp.getClockedInStatus() + "," +
                        emp.getAdminStatus());
                    //file.WriteLine(emp.getFirstName(), emp.getLastName(), emp.getUserName(), emp.getPassword(), emp.getLoginID(), emp.getClockedInStatus(), emp.getAdminStatus());
                }
            }
            else if (!File.Exists(path))
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(emp.getFirstName() + "," + 
                        emp.getLastName() + "," + 
                        emp.getUserName() + "," + 
                        emp.getPassword() + "," + 
                        emp.getLoginID() + "," + 
                        emp.getClockedInStatus() + "," + 
                        emp.getAdminStatus());
                }
            }
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