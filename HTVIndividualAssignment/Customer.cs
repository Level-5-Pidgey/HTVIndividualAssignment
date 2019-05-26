using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTVIndividualAssignment
{
    public class Customer
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

        public Customer(decimal aCustomerID, string aFirstName, string aLastName)
        {
            ID = aCustomerID;
            FirstName = aFirstName;
            LastName = aLastName;
        }

        public override string ToString()
        {
            return "[" + ID + "]: " + FirstName + " " + LastName;
        }
    }
}
