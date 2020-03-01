using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit7
{
    public class Vehicles
    {
        int number;              //ex., 12        2       1            4      2  
        public string name;       //ex., Humvee, 5 Ton, Caterpillar, LAV, LCAC,                            
        public Vehicles()
        {
            this.number = 12;
            this.name = "Humvee";
        }
        public Vehicles(int vehNumber)
        {
            this.number = vehNumber;
        }
        public void SetCount(int newVehCount)
        {
            this.number = newVehCount;
        }
        public int GetCount()
        {
            return this.number;
        }
        public void SetName(string newVehicleName)
        {
            this.name = newVehicleName;
        }

    }

}
