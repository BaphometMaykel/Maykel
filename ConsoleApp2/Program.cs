using System;

namespace ActivityArithmetic
{
    public class Math
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        //Main
        class Progs
        {
            static void Main(string[] args)
            {
                Math math = new Math();

                int num1, num2;
                //For Addition
                Console.WriteLine(" Enter First Number to Add");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine(" Enter Second Number to Add");
                num2 = int.Parse(Console.ReadLine());

                math.Add(num1, num2);

                Console.WriteLine(" total = " + math.Add(num1, num2));

                //For Subtraction
                Console.WriteLine(" Enter First Number to Subtract ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine(" Enter Second Number to Subtract");
                num2 = int.Parse(Console.ReadLine());

                math.Sub(num1, num2);

                Console.WriteLine(" total = " + math.Sub(num1, num2));


                //For Multiply
                Console.WriteLine(" Enter First Number to Multiply");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine(" Enter Second Number to Multiply");
                num2 = int.Parse(Console.ReadLine());

                math.Multiply(num1, num2);

                Console.WriteLine(" total = " + math.Multiply(num1, num2));


                //For Division
                Console.WriteLine(" Enter First Number to Divide");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine(" Enter Second Number to Divide");
                num2 = int.Parse(Console.ReadLine());

                math.Divide(num1, num2);

                Console.WriteLine(" total = " + math.Divide(num1, num2));


            }
        }

    }

}
