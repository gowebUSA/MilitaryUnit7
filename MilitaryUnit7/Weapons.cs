using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit7
{
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
}
