namespace MagicalDualPlay
{
    internal class Player
    {
        public int hp;
        public int maxHP;
        public int energy;
        public int maxEnergy;
        public int armor;
        public string name;
        public Stats skillStatistics;

        public Player(string name, int health, int energy, int armor)
        {
            this.name = name;
            this.hp = health;
            this.maxHP = health;
            this.energy = energy;
            this.maxEnergy = energy;
            this.armor = armor;
        }

        public void UPDATEHEALTH(int value)
        {
            hp = hp + value;
            if (hp > maxHP)
            {
                hp = maxHP;
            }
            if (hp < 0)
            {
                hp = 0;
            }


        }

        public void UPDATEENERGY(int value)
        {
            energy = energy + value;
            if (energy > maxEnergy)
            {
                energy = maxEnergy;
            }
            if (energy < 0)
            {
                energy = 0;
            }

        }

        public void UPDATEARMOR(int value)
        {
            armor = armor + value;
            if (armor < 0)
            {
                armor = 0;
            }
                    
        }

        public void UPDATENAME(string newName)
        {
            name = newName;
        }

        public void LearnSkill(Stats skillStats)
        {
            skillStatistics = skillStats;
        }

        public string Attack(Player target)
        {
            
            double eArmor = target.armor - skillStatistics.penetration;
            if (eArmor < 0) eArmor = 0;

            
            if (energy < skillStatistics.cost)
            {
                return $"{name} attempted to use {skillStatistics.name}, but didn't have enough energy!";
            }

            
            energy =energy- skillStatistics.cost;

         
            double Damage = skillStatistics.damage * ((100 - eArmor) / 100.0);

           
            target.UPDATEHEALTH(-(int)Damage);

            
            
            
            string attackString = $"{name} used {skillStatistics.name}, {skillStatistics.description}, against {target.name}, doing {Damage:F2} damage!";
            

            if (skillStatistics.heal > 0)
            {
                attackString += $" {name} healed for {skillStatistics.heal} health!";
            }

            if (target.hp <= 0)
            {
                attackString += $" {target.name} died.";
            }
            else
            {
                double hpPercentage = (target.hp / (double)target.maxHP) * 100;
                attackString += $" {target.name} is at {hpPercentage}% health.";
            }
            UPDATEHEALTH(skillStatistics.heal);

            return attackString;
        }
    }
}

