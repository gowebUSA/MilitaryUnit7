using System;

namespace MilitaryUnit7
{
    public class Personnel
    {
        int troop;   // 10 per squad * 3 squads + plt leader.  //if blank is private by default      //- both of these are the blueprint for variables that are required 
        public Personnel()
        {
            this.troop = 31;
        }
        public Personnel(int troopSize)
        {
            this.troop = troopSize;
        }
        public void SetSize(int newPltSize)
        {
            this.troop = newPltSize;
        }
        public int GetSize()
        {
            return this.troop;
        }
    }
    public class Team : Personnel                    //Inheritance
    {
        public string name;                          //Alpha, Bravo, Charlie Platoon that can be inherited
        public Team()
        {
            this.name = "Alpha";
        }
        public void SetName(string newPltName)
        {
            this.name = newPltName;
        }
    }
    public class Weapons
    {
        string kind;              //ex., Rifle, Machine Gun, Pistol
        public string name;       //ex., M4, M-16, 240G, .50 Cal, 9mm Baretta                            
        public Weapons()
        {
            this.kind = "Rifle";
            this.name = "M-16";
        }
        public Weapons(string wepsKind)
        {
            this.kind = wepsKind;
        }
        public void SetKind(string newWepsKind)
        {
            this.kind = newWepsKind;
        }
        public string GetKind()
        {
            return this.kind;
        }
        public void SetName(string newWepsName)
        {
            this.name = newWepsName;
        }
    }

    public class Mission
    {
        string aor;              //ex., CENTCOM, PACCOM, AFRICACOM
        public string name;       //ex., Operation Iraqi Freedaom (OIF)                           
        public Mission()
        {
            this.aor = "CENTCOM";
            this.name = "OIF";
        }
        public Mission(string aorLoc)
        {
            this.aor = aorLoc;
        }
        public void SetAOR(string newAorLoc)
        {
            this.aor = newAorLoc;
        }
        public string GetAOR()
        {
            return this.aor;
        }
        public void SetName(string newOpsName)
        {
            this.name = newOpsName;
        }
    }

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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Military Unit 7!");

            //-----------------------------------------------Team 1------------------------------------------------
            //Team1 was instantiated to default.
            Team Team1 = new Team();
            Weapons Team1Weps = new Weapons();
            Vehicles Team1Veh = new Vehicles();
            Mission Team1Mis = new Mission();
            Console.WriteLine($"\nPlatoon {Team1.name} has {Team1.GetSize()} personnel. They all carry {Team1Weps.name} {Team1Weps.GetKind()}. " +
                $"Platoon {Team1.name} has {Team1Veh.GetCount()} {Team1Veh.name}. On 12 Mar 2020, Platoon {Team1.name} will be deployed in {Team1Mis.GetAOR()} for {Team1Mis.name}.");


            //-----------------------------------------------Team 2------------------------------------------------
            Team Team2 = new Team();
            Team2.name = "Bravo";                      //just want to use other ways to call Personnel.name
            Team2.SetSize(41);                         //Have to use SetSize due to private property of Personnel.troop
            Weapons Team2Weps = new Weapons();
            Team2Weps.name = "Machine Guns";          //just want to use other ways to call Weapons.name
            Team2Weps.SetKind(".50 Cal");              //provate string variable.
            Vehicles Team2Veh = new Vehicles();
            Team2Veh.name = "LAV";
            Team2Veh.SetCount(6);
            Mission Team2Mis = new Mission();
            Team2Mis.name = "OIR";
            Team2Mis.SetAOR("PACCOM");
            Console.WriteLine($"\nPlatoon {Team2.name} has {Team2.GetSize()} personnel. They all carry {Team2Weps.GetKind()} {Team2Weps.name}. " +
                $"Platoon {Team2.name} has {Team2Veh.GetCount()} {Team2Veh.name}. On 12 Mar 2020, Platoon {Team2.name} will be deployed in {Team2Mis.GetAOR()} for {Team2Mis.name}.");


            //-----------------------------------------------Team 3------------------------------------------------
            Team Team3 = new Team();
            Team3.SetName("Charlie");
            Team3.SetSize(51);
            Weapons Team3Weps = new Weapons();
            Team3Weps.name = "Pistols";          //just want to use other ways to call Weapons.name
            Team3Weps.SetKind("9mm Barretta");              //provate string variable.
            Vehicles Team3Veh = new Vehicles();
            Team3Veh.name = "Tanks";
            Team3Veh.SetCount(4);
            Mission Team3Mis = new Mission();
            Team3Mis.name = "OBH ";
            Team3Mis.SetAOR("AFRICOM");
            Console.WriteLine($"\nPlatoon {Team3.name} has {Team3.GetSize()} personnel. They all carry {Team3Weps.GetKind()} {Team3Weps.name}. " +
                $"Platoon {Team3.name} has {Team3Veh.GetCount()} {Team3Veh.name}. On 12 Mar 2020, Platoon {Team3.name} will be deployed in {Team3Mis.GetAOR()} for {Team3Mis.name}.");

        }
    }
}
