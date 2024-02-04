namespace New_Calculator
{
    internal class Calculator
    {
        public float num1;
        public float num2;
        public Calculator()
        {
            num1 = 10;
            num2 = 10;
        }

        public Calculator(float num1, float num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public void Change(float n1, float n2)
        {
            num1 = n1;
            num2 = n2;
        }
        public float ADDITION(float num1, float num2)
        {
            return num1 + num2;
        }
        public float SUBTARCTION(float num1, float num2)
        {
            return num1 - num2;
        }
        public float MULTIPLICATION(float num1, float num2)
        {
            return num1 * num2;
        }
        public float DIVISION(float num1, float num2)
        {
            return num1 / num2;
        }

        public float Modulus(float num1, float num2)
        {
            return num1 % num2;
        }
    }
}

