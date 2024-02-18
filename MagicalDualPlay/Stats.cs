using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalDualPlay
{
    internal class Stats
    {
        public string name;
        public int damage;
        public string description;
        public int heal;
        public double penetration;
        public int cost;
        public Stats(string name, int damage, double penetration, int heal, int cost, string description)
        {
            this.name = name;
            this.damage = damage;
            this.heal = heal;
            this.cost = cost;
            this.penetration = penetration;
            this.description = description;
           
            
        }
    }
}
