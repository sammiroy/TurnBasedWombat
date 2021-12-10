using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedWombat
{
    internal class Pokemon
    {
        // Class fields
        public string PkmnName;
        public string PkmnType;
        public int PkmnLevel;
        public double EncounterWeight;

        // Class Constructor
        public Pokemon(string Name, int Level, string Type, double Weight)
        {
            PkmnName = Name;
            PkmnLevel = Level;
            PkmnType = Type;
            EncounterWeight = Weight;
        }

        internal void ShowStats()
        {
            Console.WriteLine("Name : " + this.PkmnName);
            Console.WriteLine("Level: " + this.PkmnLevel);
            Console.WriteLine("Type: " + this.PkmnType);
            Console.WriteLine("Encounter Weight: " + this.EncounterWeight);
        }
    }
}
 