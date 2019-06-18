using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
    public class EmployeeInfo
    {
        string employeeID;
        string employeeName;
        string sex;
        DateTime employeeBirthday;
        string employeeDepartment;
        string employeePost;
        string employeePhone;
        string employeeEmail;
        string employeeAddress;
        int employFalg;

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public DateTime EmployeeBirthday
        {
            get { return employeeBirthday; }
            set { employeeBirthday = value; }
        }
        public string EmployeeDepartment
        {
            get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }
        public string EmployeePost
        {
            get { return employeePost; }
            set { employeePost = value; }
        }
        public string EmployeePhone
        {
            get { return employeePhone; }
            set { employeePhone = value; }
        }
        public string EmployeeEmail
        {
            get { return employeeEmail; }
            set { employeeEmail = value; }
        }
        public string EmployeeAddress
        {
            get { return employeeAddress; }
            set { employeeAddress = value; }
        }
        public int EmployFalg
        {
            get { return employFalg; }
            set { employFalg = value; }
        }
    }
}
