using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_7
{
    public class Restourant

    {
        public void Working()
        {
            Console.WriteLine(new String('*', 30));
            Console.WriteLine( " Welcome to our restaurant!!!");
            Console.WriteLine(new String('*', 30));

            Cleaner cleanerBob = new Cleaner("Bob");
            Cook cookJhon = new Cook("Jhon");
            Manager managerMary = new Manager("Mary");

            Greetings(cleanerBob, cookJhon, managerMary);
            Console.WriteLine(new String('-', 30));

            Cleaning(cleanerBob);
            Console.WriteLine(new String('-', 30));

            Cleaning(cookJhon);
            Cooking(cookJhon);
            Console.WriteLine(new String('-', 30));

            Cooking(managerMary);
            Managing(managerMary);
            Console.WriteLine(new String('-', 30));
            Console.WriteLine("Thanks for visiting! Come again!");
            Console.WriteLine(new String('*', 30));

        }

        private static void Greetings(Cleaner cleanerBob, Cook cookJhon, Manager managerMary)
        {
            Console.WriteLine(cleanerBob);
            Console.WriteLine(cookJhon);
            Console.WriteLine(managerMary);
        }

        private static void Managing(IManagement managersWork)
        {
            managersWork.DoManage();
        }

        private static void Cooking(ICooking cooksWork)
        {
            cooksWork.DoCooking();
        }

        private static void Cleaning(ICleaning cleanersWork)
        {
            cleanersWork.DoCleaning();
        }
    }
}
