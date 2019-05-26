using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTVIndividualAssignment
{
    public class AddOn
    {
        public decimal ID
        {
            get;
            private set;
        }

        public decimal VehicleID
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

        public decimal Cost
        {
            get;
            private set;
        }

        public AddOn(decimal aAddOnID, decimal aVehicleID, string aAddOnName, decimal aAddOnCost)
        {
            ID = aAddOnID;
            VehicleID = aVehicleID;
            Name = aAddOnName;
            Cost = aAddOnCost;
        }

        public override string ToString()
        {
            return Name + ": $" + Convert.ToDouble(Cost);
        }
    }
}
