using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClockIn
{
    class Employee
    {
        private String firstName, lastName, userName, password, loginID;
        private Boolean clockedInStatus, adminStatus;
        private double countingTotal;

        public Employee()
        {
            firstName = lastName = userName = password = loginID = "";
            clockedInStatus = adminStatus = false;
            countingTotal = 0;
        }

        public Employee(String firstName, String lastName, String userName, String password, String loginID, Boolean clockedInStatus, Boolean adminStatus)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.password = password;
            this.loginID = loginID;
            this.clockedInStatus = clockedInStatus;
            this.adminStatus = adminStatus;
            this.countingTotal = 0;
        }

        public void setCountingTotal(double countTotal) {
            this.countingTotal = countTotal;
        }

        public double getCountingTotal()
        {
            return this.countingTotal;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public void SetUserName(String userName)
        {
            this.userName = userName;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public void setLoginID(String loginID)
        {
            this.loginID = loginID;
        }

        public void setClockedInStatus(Boolean clockedInStatus)
        {
            this.clockedInStatus = clockedInStatus;
        }

        public void setAdminStatus(Boolean adminStatus)
        {
            this.adminStatus = adminStatus;
        }

        public String getFirstName()
        {
            return this.firstName;
        }

        public String getLastName()
        {
            return this.lastName;
        }

        public String getUserName()
        {
            return this.userName;
        }

        public String getPassword()
        {
            return this.password;
        }

        public String getLoginID()
        {
            return this.loginID;
        }

        public Boolean getClockedInStatus()
        {
            return this.clockedInStatus;
        }

        public Boolean getAdminStatus()
        {
            return this.adminStatus;
        }
    }
}
