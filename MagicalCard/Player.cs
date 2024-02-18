namespace MagicalCard
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

        public Player(string name, int hp, int energy, int armor)
        {
            this.name = name;
            this.hp = hp;
            this.maxHP = hp;
            this.energy = energy;
            this.maxEnergy = energy;
            this.armor = armor;

        }

        public void UpdateHealth(int value)
        {
            hp = hp + value;
            if (hp < 0)
            {
                hp = 0;

            }
            else if (hp > maxHP)
            {
                hp = maxHP;
            }
        }

        public void UpdateEnergy(int value)
        {
            energy = energy + value;
            if (energy < 0)
            {
                energy = 0;
            }
            else if (energy > maxEnergy)
            {
                energy = maxEnergy;
            }
        }
        public void UpdateArmor(int value)
        {
            armor = armor + value;
        }
        public void UpdateName(string newName)
        {
            name = name + newName;
        }
        public void learnSkill(Stats s)
        {
            skillStatistics = s;
        }
        public string attack(Player targets)
        { 
             if (skillStatistics == null)
             {
                 return "No Skill Learned!";
             }
            if (energy < skillStatistics.cost)
            {
                return $"{name} attempted to use {skillStatistics.name}, but didn't have enough energy!";
            }

            // Subtract energy cost
            energy -= skillStatistics.cost;

            int eArmor = targets.armor - (int)(skillStatistics.penetration);
            if (eArmor < 0) { eArmor = 0; }

            double calculatedDamage = skillStatistics.damage * ((100 - eArmor) / 100.0);
            targets.hp = targets.hp - (int)calculatedDamage;
            hp += skillStatistics.heal;
            string attackString = $"{name} used {skillStatistics.name}, {skillStatistics.description}, against {targets.name}, doing {calculatedDamage:F1} damage!";
            if (skillStatistics.heal > 0)
                attackString += $" {name} healed for {skillStatistics.heal} health!";

            if (targets.hp <= 0)
                attackString += $" {targets.name} died.";
            else
                attackString += $" {targets.name} is at {((double)targets.hp / targets.maxHP) * 100:F2}% health.";

            return attackString;
        }
    }
}
