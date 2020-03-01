using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit7
{
    public class Mission
    {
        string aor;              //ex., CENTCOM, PACCOM, AFRICACOM
        //public string name;     //ex., Operation Iraqi Freedaom (OIF)             
        public Mission()
        {
            this.aor = "CENTCOM";
            //this.name = "OIF";
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
        //public void SetName(string newOpsName)
        //{
        //    this.name = newOpsName;
        //}
}
    public class Ops : Mission
    {
        public string name;       //ex., Operation Iraqi Freedaom (OIF) 
        public Ops()
        {
            this.name = "OIF";
        }
        public void SetName(string newOpsName)
        {
            this.name = newOpsName;
        }
    }
    public class SecretMis : Operation
    {
        public override void Socom()                                      //Override
        {
            Console.WriteLine("Secret Alpha Mission");
        }
    }
}
