using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTVIndividualAssignment
{
    public class Vehicle
    {
        public decimal ID
        {
            get;
            private set;
        }

        public string Model
        {
            get;
            private set;
        }

        public string Manufacturer
        {
            get;
            private set;
        }

        public int Year
        {
            get;
            private set;
        }

        public decimal Cost
        {
            get;
            private set;
        }

        public Vehicle(decimal aVehicleID, string aVehicleModel, string aVehicleManufacturer, int aVehicleYear, decimal aVehicleCost)
        {
            ID = aVehicleID;
            Model = aVehicleModel;
            Manufacturer = aVehicleManufacturer;
            Year = aVehicleYear;
            Cost = aVehicleCost;
        }

        public override string ToString()
        {
            return "[" + ID + "]: " + Year + " " + Manufacturer + " " + Model + " ($" + Convert.ToDouble(Cost) + ")";
        }
    }
}
