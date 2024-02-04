using System;

namespace New_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Calculator calculator = new Calculator(1, 1);
            while (true)
            {
                Console.WriteLine("\t\t\t\tWELCOME TO MY CALCULATOR....");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Modulo");
                Console.WriteLine("6.Change Attributes");
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
                    if (calculator.num2 < 1)
                    {
                        Console.WriteLine("Invalid..");
                    }

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
                    Console.WriteLine("Enter new value for 1st Number: ");
                    calculator.num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter new value for 2nd Number: ");
                    calculator.num2 = float.Parse(Console.ReadLine());
                    calculator.Change(calculator.num1, calculator.num2);
                    Console.WriteLine("New Values are {0}", (calculator.num1, calculator.num2));
                    Console.ReadLine();

                }
                else if (op == 7)
                {
                    Environment.ExitCode = 0;
                }
            }
        }
    }
}