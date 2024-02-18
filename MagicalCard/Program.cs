using System;

namespace MagicalCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player alice = new Player("Alice", 110, 50, 10);
            Player bob = new Player("Bob", 100, 60, 20);

            Stats fireball = new Stats("fireball", 23, 1.2, 5, 15, "a firey magical attack");
            alice.learnSkill(fireball);
            Console.ReadLine();
            Console.WriteLine(alice.attack(bob));
            Console.ReadLine();
            // Alice used fireball, a firey magical attack, against Bob, doing
            // 18.68 damage! Alice healed for 5 health! Bob is at 81.32% health.
            Stats superbeam = new Stats("superbeam", 200, 50, 50, 75, "an overpowered attack, pls nerf");
            
            Console.WriteLine(bob.attack(alice));
            Console.ReadLine();
            // Bob attempted to use superbeam, but didn't have enough energy!

        }
    }
}