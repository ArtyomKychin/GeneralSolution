using System;

namespace HomeApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        public static void Task1()

        {

            Console.WriteLine("Please, enter number 1");
            double operand1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please, enter number 2");
            double operand2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please, enter the desired arithmetic operation\nThe following actions are available: + , - , * , / ");
            string sign = Convert.ToString(Console.ReadLine());

            if (sign != "+" && sign != "-" && sign != "*" && sign != "/")//validation of signs of arithmetic operations
            {
                Console.WriteLine("Please use the correct arithmetic symbol\nThe following actions are available: + , - , * , / ");

            }

            switch (sign)
            {
                case "+":
                    {
                        double result = operand1 + operand2;

                        Console.WriteLine("The sum = " + result);
                        break;
                    }

                case "-":
                    {
                        double result = operand1 - operand2;

                        Console.WriteLine("The difference = " + result);
                        break;
                    }

                case "*":
                    {
                        double result = operand1 * operand2;
                        Console.WriteLine("The multiplication result = " + result);
                        break;
                    }

                case "/":
                    {
                        if (operand2 == 0)
                            Console.WriteLine("Action incorrect (/0)");
                        else
                        {
                            double result = operand1 / operand2;
                            Console.WriteLine("The quotient = " + result);
                        }

                        break;
                    }

            }

        }
        public static void Task2()

        {
        start:
            Console.WriteLine("Please, enter number in range 0-100");
            int number = Convert.ToInt16(Console.ReadLine());

            if (number >= 0 & number <= 100)
            {
                if (number >= 0 & number <= 14)
                {
                    Console.WriteLine(" Your number is in the range [0-14]");
                }
                else if (number >= 15 & number <= 35)
                {
                    Console.WriteLine(" Your number is in the range [15-35]");
                }
                else if (number >= 36 & number <= 50)
                {
                    Console.WriteLine(" Your number is in the range [36-50]");
                }
                else if (number >= 50 & number <= 100)
                {
                    Console.WriteLine(" Your number is in the range [50-100]");
                }
            }
            else
            {
                Console.WriteLine("Your number is not included in the specified range");

            }
            goto start;


        }

        public static void Task3()

        {
        start:
            Console.WriteLine("Enter a word that characterizes the weather in Russian");
            Console.WriteLine("The following words are available for translation:\nветренно, солнечно, дождливо, снег, облачно, жарко, холодно, сыро, сухо, штиль");
            string word = Convert.ToString(Console.ReadLine());

            switch (word)
            {
                case "ветренно":
                    Console.WriteLine("ветренно = windy ");
                    break;
                case "солнечно":
                    Console.WriteLine("солнечно = windy ");
                    break;
                case "дождливо":
                    Console.WriteLine("дождливо = it is rainy");
                    break;
                case "снег":
                    Console.WriteLine("снег = snow");
                    break;
                case "облачно":
                    Console.WriteLine("облачно = cloudy");
                    break;
                case "жарко":
                    Console.WriteLine("жарко = hot");
                    break;
                case "холодно":
                    Console.WriteLine("холодно = Cold");
                    break;
                case "сыро":
                    Console.WriteLine("сыро = damp");
                    break;
                case "сухо":
                    Console.WriteLine("сухо = dry");
                    break;
                case "штиль":
                    Console.WriteLine("штиль = calm");
                    break;
                default:
                    Console.WriteLine("The word is not in the dictionary");
                    break;
            }
            goto start;




        }

        public static void Task4()

        {
        start:
            Console.WriteLine("Please enter a number");

            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("your number is odd");
            }
            goto start;

        }

    }
}