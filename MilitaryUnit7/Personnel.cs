using System;
using System.Collections.Generic;
using System.Text;

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
    public class SecretPers : Operation
    {
        public override void Socom()                      //Override
        {
            Console.WriteLine("Secret Alpha Platoon");
        }
    }

}
