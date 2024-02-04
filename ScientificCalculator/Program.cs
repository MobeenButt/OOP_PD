using System;
using System.Xml.Serialization;

namespace ScientificCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Scientific calculator = new Scientific(1, 1);
            Console.WriteLine("\t\t\t\tWELCOME TO MY CALCULATOR....");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Modulo");
            Console.WriteLine("6.Square Root");
            Console.WriteLine("7.Exponent");
            Console.WriteLine("8.Logarithm");
            Console.WriteLine("9.Trigonometric");
            Console.WriteLine("10.Exit");
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                Console.WriteLine("Enter 1st Number: ");
                calculator.num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number: ");
                calculator.num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Result is {0}", calculator.ADDITION(calculator.num1, calculator.num2));
                Console.ReadLine();
            }
            else if (op == 2)
            {
                Console.WriteLine("Enter 1st Number: ");
                calculator.num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number: ");
                calculator.num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Result is {0}", calculator.SUBTARCTION(calculator.num1, calculator.num2));
                Console.ReadLine();
            }
            else if (op == 3)
            {
                Console.WriteLine("Enter 1st Number: ");
                calculator.num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number: ");
                calculator.num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Result is {0}", calculator.MULTIPLICATION(calculator.num1, calculator.num2));
                Console.ReadLine();
            }
            else if (op == 4)
            {
                Console.WriteLine("Enter 1st Number: ");
                calculator.num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number: ");
                calculator.num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Result is {0}", calculator.DIVISION(calculator.num1, calculator.num2));
            }
            else if (op == 5)
            {
                Console.WriteLine("Enter 1st Number: ");
                calculator.num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number: ");
                calculator.num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Result is {0}", calculator.Modulus(calculator.num1, calculator.num2));
                Console.ReadLine();
            }
            else if (op == 6)
            {
                Console.WriteLine("Enter 1st Number: ");
                calculator.num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number: ");
                calculator.num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Result is {0}", calculator.SQUAREROOT(calculator.num1));
                Console.ReadLine();
            }

            else if (op == 7)
            {
                Console.WriteLine("Enter 1st Number: ");
                calculator.num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number: ");
                calculator.num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Result is {0}", calculator.Exponet(calculator.num1));
                Console.ReadLine();

            }
            else if (op == 8)
            {
                Console.WriteLine("Enter 1st Number: ");
                calculator.num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number: ");
                calculator.num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Result is {0}", calculator.Logarithm(calculator.num1));
                Console.ReadLine();

            }
            else if (op == 9)
            {
                Console.WriteLine("Enter 1st Number: ");
                calculator.num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("SIN,COSE,TAN...");
                string choice;
                choice = Console.ReadLine();
                if (choice == "SIN")
                {
                    Console.WriteLine("Result is {0}", calculator.TrigonometricSin(calculator.num1));
                    Console.ReadLine();
                }
                else if (choice == "COSE")
                {
                    Console.WriteLine("Result is {0}", calculator.TrigonometricCos(calculator.num1));
                    Console.ReadLine();
                }
                else if (choice == "TAN")
                {
                    Console.WriteLine("Result is {0}", calculator.TrigonometricTan(calculator.num1));
                    Console.ReadLine();
                }
            }
            else if (op == 10)
            {
                Environment.ExitCode = 0;
            }
        }
    }
}

