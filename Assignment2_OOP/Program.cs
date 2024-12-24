namespace Assignment2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /************************Part 01********************************/
            #region Q1
            ////1. Design and implement a Class for the employees in a company:
            ////Employee is identified by an ID, Name, security level, salary, 
            ////hire date and Gender.
            #endregion

            #region Q2
            ////2. Develop a Class to represent the Hiring Date Data:
            ////consisting of fields to hold the day, month and Years.
            #endregion

            #region Q3
            ////3. We need to restrict the Gender field to be only M or F[Male or Female]
            #endregion

            #region Q4
            ////4. Assign the following security privileges to the employee(guest, Developer, 
            ////secretary and DBA) in a form of Enum
            #endregion

            #region Q5
            ////5. We want to provide the Employee Class to represent Employee data in a string 
            ////Form(override ToString()), display employee salary in a currency format. 
            ////[use String.Format Function]
            #endregion

            #region Q6
            ////6, Create an array of Employees with size three a DBA, Guest and the third one is 
            ////security officer who have full permissions. (Employee[] EmpArr;)
            Employee[] EmpArr;
            EmpArr = new Employee[3] ;
            Secprivileges securityOfficer = Secprivileges.Developer & Secprivileges.DBA&Secprivileges.guest&Secprivileges.secretary;
            EmpArr[0]=new Employee(1,"Hossam",Secprivileges.DBA,5000500,new Date_Data(25,12,2000),Gender.M) ;
            EmpArr[1] = new Employee(2, "Mona", Secprivileges.guest, 3005600, new Date_Data(7, 1, 1995), Gender.F);
            EmpArr[2] = new Employee(3, "Ali", securityOfficer, 500000, new Date_Data(13, 5, 1880), Gender.M);
            #endregion
            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine(EmpArr[i]);
            }
        }
    }
}
