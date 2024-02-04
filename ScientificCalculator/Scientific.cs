using System;

namespace ScientificCalculator
{
    internal class Scientific
    {
        public double num1;
        public double num2;
        double res;
        public Scientific(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double ADDITION(double num1, double num2)
        {
            return num1 + num2;
        }
        public double SUBTARCTION(double num1, double num2)
        {
            return num1 - num2;
        }
        public double MULTIPLICATION(double num1, double num2)
        {
            return num1 * num2;
        }
        public double DIVISION(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Modulus(double num1, double num2)
        {
            return num1 % num2;
        }

        public double SQUAREROOT(double num1)
        {
            res = Math.Sqrt(num1);
            return res;
        }
        public double Exponet(double num1)
        {
            return Math.Exp(num1);
        }
        public double Logarithm(double num1)
        {
            return Math.Log(num1);
        }

        public double TrigonometricCos(double num1)
        {
            return Math.Cos(num1);
        }

        public double TrigonometricSin(double num1)
        {
            return Math.Sin(num1);
        }
        public double TrigonometricTan(double num1)
        {
            return Math.Tan(num1);
        }
    }

}

