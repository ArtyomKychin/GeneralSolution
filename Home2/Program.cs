using System;

namespace HomeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter number 1");
            double operand1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please, enter number 2");
            double operand2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please, enter the desired arithmetic operation\nThe following actions are available: + , - , * , / ");
            string sign = Convert.ToString(Console.ReadLine());

            if (sign == "+")
            {
                double result = operand1 + operand2;

                Console.WriteLine("The sum = " + result);
            }
            else if (sign == "-")
            {
                double result = operand1 - operand2;

                Console.WriteLine("The difference = " + result);
            }
            else if (sign == "*")
            {
                double result = operand1 * operand2;
                Console.WriteLine("The multiplication result = " + result);
            }
            else if (sign == "/")
            {
                if (operand2 == 0)
                    Console.WriteLine("Action incorrect (/0)");
                else
                {
                    double result = operand1 / operand2;
                    Console.WriteLine("The quotient = " + result);
                }
            }

        }
        
       
       
    }

}