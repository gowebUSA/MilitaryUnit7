using System;

namespace MilitaryUnit7
{
    
    

    

    
    class Program
    {
        static void doWork()
        {
            //-----------------------------------------------Team 1------------------------------------------------
            //Team1 was instantiated to default.
            Team Team1 = new Team();
            Weapons Team1Weps = new Weapons();
            Vehicles Team1Veh = new Vehicles();
            Ops Team1Mis = new Ops();
            Console.WriteLine($"\nPlatoon {Team1.name} has {Team1.GetSize()} personnel. They all carry {Team1Weps.name} {Team1Weps.GetKind()}. " +
                $"Platoon {Team1.name} has {Team1Veh.GetCount()} {Team1Veh.name}. On 12 Mar 2020, Platoon {Team1.name} will be deployed in {Team1Mis.GetAOR()} for {Team1Mis.name}.");

            Console.WriteLine("Secret Mission");
            //Operation s = Team1;                               //Giving me errors on Team1 and Team1Mis.
            //s.Socom();
            //s = Team1Mis;
            //s.Socom();


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
            Ops Team2Mis = new Ops();
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
            Ops Team3Mis = new Ops();
            Team3Mis.name = "OBH ";
            Team3Mis.SetAOR("AFRICOM");
            Console.WriteLine($"\nPlatoon {Team3.name} has {Team3.GetSize()} personnel. They all carry {Team3Weps.GetKind()} {Team3Weps.name}. " +
                $"Platoon {Team3.name} has {Team3Veh.GetCount()} {Team3Veh.name}. On 12 Mar 2020, Platoon {Team3.name} will be deployed in {Team3Mis.GetAOR()} for {Team3Mis.name}.");

        }
        static void Main(string[] args)
        {
            //Use Vehicles chap 12 as ref.
            Console.WriteLine("Military Unit 7!");

            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
