using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_OOP
{
	enum Gender { M = 1, F = 2, Male = 1, Female = 2 }
	enum Secprivileges { guest, Developer, secretary, DBA }
    internal class Employee
    {
        #region variables
        private int id;
        private string name;
        private Secprivileges securityLevel;
        private decimal salary;
        private Date_Data hireDate;
        private Gender gender;
        #endregion
       
        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Secprivileges SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }

        //public string Salary
        //{
        //    get { return string.Format("{0:C}", salary); }
        //    set(decimal salary) { salary = value; }
        //}
        
        public Date_Data HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        #endregion
        #region Constructor
        public Employee()
        {
            
        }
        public Employee(int id,string name,Secprivileges securityLevel,decimal salary,Date_Data hireDate,Gender gender)
        {
            this.id = id;
            this.name = name;
            this.securityLevel = securityLevel;
            this.salary = salary;
            this.hireDate = hireDate;
            this.gender = gender;
        }
        #endregion
        #region methods
        public void SetSalary(decimal value)
        {
            salary = value;
        }
        public string GetSalary()
        {
            return string.Format("{0:C}", Convert.ToDecimal(salary));
        }
        public override string ToString()
        {
            return $" Emp ID: {id}\n Emp Name: {name}\n Security Level: {securityLevel}\n Salary: {GetSalary()}\n" +
                $"Hire Date: {hireDate}\n Gender: {gender}\n";
        }
        #endregion

    }
}
