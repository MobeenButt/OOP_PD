using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalCard
{
    internal class Stats
    {
        public string name;
        public int damage;
        public double penetration;
        public int cost;
        public string description;
        public int heal;

        public Stats(string name, int damage, double penetration, int cost, int heal, string description)
        {
            this.name = name;
            this.damage = damage;
            this.penetration = penetration;
            this.cost = cost;
            this.description = description;
            this.heal = heal;
        }
    }
}
