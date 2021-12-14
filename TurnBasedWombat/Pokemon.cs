using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedWombat
{
    class Pokemon
    {
        // Class fields
        private string name;
        private string type;
        private int level;

        // Class Constructor
        public Pokemon(string Name, string Type,  int Level)
        {
            name = Name;
            type = Type;
            level = Level;
        }

        // Methods
        public void ShowStats()
        {
            Console.WriteLine("Name : " + this.name);
            Console.WriteLine("Level: " + this.level);
            Console.WriteLine("Type: " + this.type);
        }

    }
}
 