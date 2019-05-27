using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTVIndividualAssignment
{
    public class Employee
    {
        public decimal ID
        {
            get;
            private set;
        }

        public string FirstName
        {
            get;
            private set;
        }

        public string LastName
        {
            get;
            private set;
        }

        public enum EmployeeTypeEnum
        {
            Salesman,
            Manager,
            Administrator
            //Could easily add more user types here later (e.g. SysAdmin, CEO, whatever) for different permissions
        }

        public EmployeeTypeEnum EmployeeType
        {
            get;
            private set;
        }

        public Employee(decimal aEmployeeID, string aFirstName, string aLastName, int aEmployeeType)
        {
            ID = aEmployeeID;
            FirstName = aFirstName;
            LastName = aLastName;
            EmployeeType = (EmployeeTypeEnum)aEmployeeType; //Casting the employeetype from an integer -> enum makes it more clear what type of staff this employee is
        }

        public override string ToString()
        {
            return "[" + ID + "]: " + FirstName + " " + LastName + " (" + nameof(EmployeeType) + ")";
        }
    }
}
