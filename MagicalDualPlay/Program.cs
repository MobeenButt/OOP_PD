using System;
using System.Collections.Generic;

namespace MagicalDualPlay
{
    internal class Program
    {
        static List<Player> P = new List<Player>();
        static List<Stats> Skill = new List<Stats>();

        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 6)
            {
                Console.WriteLine("\t\tMagical_Dual\t\t\n");
                Console.WriteLine("1.Add Player");
                Console.WriteLine("2.Add Skill Statistics");
                Console.WriteLine("3.Player Info");
                Console.WriteLine("4.Learn a Skill");
                Console.WriteLine("5.Attack");
                Console.WriteLine("6.Exit");

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter Player details: ");
                    P.Add(CREATEPLAYER());
                    Console.WriteLine("Player Added Successfully!");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter Skill details:");
                    Skill.Add(CreateSkill());
                    Console.WriteLine("Skill Statistics Added Successfully!");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Player Information:");
                    foreach (var player in P)
                    {
                        Console.WriteLine($"Name: {player.name}, Health: {player.hp}, Energy: {player.energy}, Armor: {player.armor}");
                    }
                }
                else if (choice == 4)
                {
                    Console.Write("Enter Player name: ");
                    string Name = Console.ReadLine();
                    Player player = null;
                    foreach (var p in P)
                    {
                        if (p.name.Equals(Name, StringComparison.OrdinalIgnoreCase))
                        {
                            player = p;
                            break;
                        }
                    }
                    if (player != null)
                    {
                        Console.Write("Enter skill name: ");
                        string skillName = Console.ReadLine();
                        Stats skill = null;
                        foreach (var s in Skill)
                        {
                            if (s.name.Equals(skillName, StringComparison.OrdinalIgnoreCase))
                            {
                                skill = s;
                                break;
                            }
                        }
                        if (skill != null)
                        {
                            player.LearnSkill(skill);
                            Console.WriteLine($"{Name} learned {skillName} successfully!");
                        }
                        else
                        {
                            Console.WriteLine($"Skill '{skillName}' not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Player '{Name}' not found.");
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Choose the Attacking Player:");
                    Console.WriteLine("Player Information:");
                    foreach (var player in P)
                    {
                        Console.WriteLine($"Name: {player.name}, Health: {player.hp}, Energy: {player.energy}, Armor: {player.armor}");
                    }
                    Console.Write("Enter the Name of the Attacking Player: ");
                    string attackerName = Console.ReadLine();
                    Player attacker = null;
                    foreach (var p in P)
                    {
                        if (p.name.Equals(attackerName, StringComparison.OrdinalIgnoreCase))
                        {
                            attacker = p;
                            break;
                        }
                    }
                    if (attacker != null)
                    {
                        Console.WriteLine("Choose the Target Player:");
                        Console.WriteLine("Player Information:");
                        foreach (var player in P)
                        {
                            Console.WriteLine($"Name: {player.name}, Health: {player.hp}, Energy: {player.energy}, Armor: {player.armor}");
                        }
                        Console.Write("Enter the name of the Target Player: ");
                        string targetName = Console.ReadLine();
                        Player target = null;
                        foreach (var p in P)
                        {
                            if (p.name.Equals(targetName, StringComparison.OrdinalIgnoreCase))
                            {
                                target = p;
                                break;
                            }
                        }
                        if (target != null)
                        {
                            Console.WriteLine(attacker.Attack(target));
                        }
                        else
                        {
                            Console.WriteLine($"Target Player '{targetName}' not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Attack's Player '{attackerName}' not found.");
                    }
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Exiting Program...");
                }
                else
                {
                    Console.WriteLine("Invalid Choice!");
                }
            }
        }
        static Player CREATEPLAYER()
        {
            Console.Write("Enter Player's Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Player's Health: ");
            int health = int.Parse(Console.ReadLine());

            Console.Write("Enter Player's Energy: ");
            int energy = int.Parse(Console.ReadLine());

            Console.Write("Enter Player's Armor: ");
            int armor = int.Parse(Console.ReadLine());

            return new Player(name, health, energy, armor);
        }

        static Stats CreateSkill()
        {
            Console.Write("Enter Skills Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Skills Damage: ");
            int damage = int.Parse(Console.ReadLine());

            Console.Write("Enter Skills Penetration: ");
            double penetration = double.Parse(Console.ReadLine());

            Console.Write("Enter Skills Heal Power: ");
            int heal = int.Parse(Console.ReadLine());

            Console.Write("Enter Skills Cost: ");
            int cost = int.Parse(Console.ReadLine());

            Console.Write("Enter Skills Description: ");
            string description = Console.ReadLine();

            return new Stats(name, damage, penetration, heal, cost, description);
        }

    }
}