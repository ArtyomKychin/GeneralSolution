using System;

namespace HomeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberStr = Console.ReadLine();     
            
            int number1 = int.Parse(numberStr);

            if ((number1 > 5) && (number1 < 10))
            {
                Console.WriteLine("The number is bigger");                
            }
            else
            {
                Console.WriteLine("unknown number");
            }

        }



    }

}