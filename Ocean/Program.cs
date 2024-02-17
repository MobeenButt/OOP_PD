using System;

namespace Ocean
{
    internal class Program
    {
        static int shipCount = 0;

        static void Main(string[] args)
        {
            Ship[] ships = new Ship[10]; // Assuming a maximum of 10 ships can be added
            string op = "";
            while (true)
            {
                op = Menu();
                if (op == "1")
                {
                    //if (shipCount < 10)
                    //{
                    //    Console.Clear();
                    //    Console.WriteLine("Enter Ship Number: ");
                    //    string number = Console.ReadLine();
                    //    Console.WriteLine("Enter Ship Latitude: ");
                    //    Console.WriteLine("Enter Latitude's Degree: ");
                    //    int latDeg = int.Parse(Console.ReadLine());
                    //    Console.WriteLine("Enter Latitude's Minute: ");
                    //    int latMin = int.Parse(Console.ReadLine());
                    //    Console.WriteLine("Enter Latitude's Direction: ");
                    //    char latDir = char.Parse(Console.ReadLine());

                    //    Angle lat = new Angle(latDeg, latMin, latDir);

                    //    Console.WriteLine("Enter Ship Longitude: ");
                    //    Console.WriteLine("Enter Longitude's Degree: ");
                    //    int lonDeg = int.Parse(Console.ReadLine());
                    //    Console.WriteLine("Enter Longitude's Minute: ");
                    //    int lonMin = int.Parse(Console.ReadLine());
                    //    Console.WriteLine("Enter Longitude's Direction: ");
                    //    char lonDir = char.Parse(Console.ReadLine());

                    //    Angle lon = new Angle(lonDeg, lonMin, lonDir);

                    //    ships[shipCount] = new Ship(lat, lon, number);
                    //    shipCount++;
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Maximum Limit Reached!");
                    //    Console.ReadLine();
                    //}
                    AddShip(ships);
                }
                else if (op == "2")
                {
                    Console.WriteLine("Enter Ship Serial Number to find its position: ");
                    string number = Console.ReadLine();
                    bool found = false;
                    foreach (var ship in ships)
                    {
                        if (ship != null && ship.Number == number)
                        {
                            ship.PrintPosition();
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                        Console.WriteLine("No such ship found.");
                }
                else if (op == "3")
                {
                    Console.Write("Enter the ship latitude: ");
                    string lat = Console.ReadLine();
                    Console.Write("Enter the ship longitude: ");
                    string log = Console.ReadLine();
                    bool found = false;
                    foreach (var ship in ships)
                    {
                        if (ship != null && ship.Latitude.DisplayAngle()==lat && ship.Longitude.DisplayAngle()==log)
                        {
                            ship.PrintPosition();
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                        Console.WriteLine("No such ship found.");
                }
                else if (op == "4")
                {
                    Console.Write("Enter Ship’s serial number whose position you want to change: ");
                    string serialNumber = Console.ReadLine();

                    // Find the ship with the provided serial number
                    Ship shipToUpdate = null;
                    foreach (var ship in ships)
                    {
                        if (ship != null && ship.Number == serialNumber)
                        {
                            shipToUpdate = ship;
                            break;
                        }
                    }

                    if (shipToUpdate != null)
                    {
                        Console.WriteLine("Enter Ship Latitude:");
                        Console.Write("Enter Latitude’s Degree: ");
                        int latDeg = int.Parse(Console.ReadLine());
                        Console.Write("Enter Latitude’s Minute: ");
                        float latMin = float.Parse(Console.ReadLine());
                        Console.Write("Enter Latitude’s Direction: ");
                        char latDir = char.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Ship Longitude:");
                        Console.Write("Enter Longitude’s Degree: ");
                        int lonDeg = int.Parse(Console.ReadLine());
                        Console.Write("Enter Longitude’s Minute: ");
                        float lonMin = float.Parse(Console.ReadLine());
                        Console.Write("Enter Longitude’s Direction: ");
                        char lonDir = char.Parse(Console.ReadLine());

                        // Update ship's position
                        shipToUpdate.Latitude.ChangeAngle(latDeg, latMin, latDir);
                        shipToUpdate.Longitude.ChangeAngle(lonDeg, lonMin, lonDir);

                        Console.WriteLine("Ship's position has been updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No ship found with the provided serial number.");
                    }
                }
                else if (op == "5")
                {
                    break;
                }

                Console.WriteLine("\n\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static string Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Ship");
            Console.WriteLine("2. View Ship Position");
            Console.WriteLine("3. View Ship Serial Number");
            Console.WriteLine("4. Change Ship Position");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your Option...");
            return Console.ReadLine();
        }
        static void AddShip(Ship[] ships)
        {
            if (shipCount < 10)
            {
                Console.Clear();
                Console.WriteLine("Enter Ship Number: ");
                string number = Console.ReadLine();

                Console.WriteLine("Enter Ship Latitude: ");
                Console.Write("Enter Latitude's Degree: ");
                int latDeg = int.Parse(Console.ReadLine());
                Console.Write("Enter Latitude's Minute: ");
               float latMin = float.Parse(Console.ReadLine());
                Console.Write("Enter Latitude's Direction: ");
                char latDir = char.Parse(Console.ReadLine());

                Angle lat = new Angle(latDeg, latMin, latDir);

                Console.WriteLine("Enter Ship Longitude: ");
                Console.Write("Enter Longitude's Degree: ");
                int lonDeg = int.Parse(Console.ReadLine());
                Console.Write("Enter Longitude's Minute: ");
                float lonMin = float.Parse(Console.ReadLine());
                Console.Write("Enter Longitude's Direction: ");
                char lonDir = char.Parse(Console.ReadLine());

                Angle lon = new Angle(lonDeg, lonMin, lonDir);

                ships[shipCount] = new Ship(lat, lon, number);
                shipCount++;
            }
            else
            {
                Console.WriteLine("Maximum Limit Reached!");
                Console.ReadLine();
            }
        }
    }

    internal class Ship
    {
        public Angle Latitude;
        public Angle Longitude;
        public string Number;

        public Ship(Angle latitude, Angle longitude, string number)
        {
            Latitude = latitude;
            Longitude = longitude;
            Number = number;
        }

        public void PrintPosition()
        {
            Console.WriteLine("Ship is at {0} and {1}", Latitude.DisplayAngle(), Longitude.DisplayAngle());
        }
        public void PrintSerial()
        {
            Console.WriteLine("Ship's serial number is {0}", Number);
        }
    }

    internal class Angle
    {
        public int Degrees;
        public float Minutes;
        public char Direction;

        public Angle(int degrees, float minutes, char direction)
        {
            Degrees = degrees;
            Minutes = minutes;
            Direction = direction;
        }

        public void ChangeAngle(int deg, float min, char dir)
        {
            Degrees = deg;
            Direction = dir;
            Minutes = min;
        }

        public string DisplayAngle()
        {
            return $"{Degrees} \u00b0 {Direction} {Minutes}";
        }
    }
}
