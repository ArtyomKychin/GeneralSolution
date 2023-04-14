using System;
//using System.Linq;
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
            Task5();
            Task6();
        }
        
        static void Task1() //test->testing
        {
            string source = "1234 test 5667 test 8973 test 5647";
            Console.WriteLine(source);
            source = source.Replace("test", "testing");
            Console.WriteLine(source);
        }

        static void Task2() //Welcome, to, the, TMS, lessons
        {
            string welk = "Welcome";
            string to = "to";
            string the = "the";
            string tms = "TMS";
            string lessons = "lessons";
            string[] values = new string[] { welk, to, the, tms, lessons };
            
            for(int i = 0; i < values.Length; i++)
            {
                values[i] = string.Concat('"', values[i] , '"');
            }
            string phrase = string.Join(" ", values);
            Console.WriteLine(phrase);
        }

        static void Task3() //teamwithsomeofexcersicesabcwanttomakeitbetter
        {
            string str = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            int ind = str.IndexOf("abc");
            string firstpart = str.Remove(ind);
            string secondpart = str.Remove(0,ind + 3);
            Console.WriteLine($"firstpart {firstpart}");
            Console.WriteLine($"secondpart {secondpart}");
        }
        static void Task4() //Good day
        {
            string someday = "Good day";
            string someday1 = someday.Substring(4);
            string someday2 = someday1.Insert(0, "The best");
            someday2 = someday2.Insert(someday2.Length, " !!!!!!!!!");
            int ind = someday2.LastIndexOf("!");
            someday2 = someday2.Remove(ind);
            someday2 = someday2.Insert(someday2.Length, "?");
            Console.WriteLine(someday);
            Console.WriteLine(someday2);
        }

        static void Task5() //Char.IsDigit()
        {
            string somestring = Console.ReadLine();
            string numstring = " ";
            for(int i = 0; i < somestring.Length; i++)
            {
                if (char.IsDigit(somestring[i]))
                {
                    numstring += somestring[i];
                }
            }
            Console.Write(numstring);
        }
        static void Task6() //sentence comparison
        {
            Console.WriteLine("Enter a sentece 1:");
            string string1 = Console.ReadLine();
            string[] sentence1 = string1.Split(" ");

            Console.WriteLine("Enter a sentece 2:");
            string string2 = Console.ReadLine();
            string[] sentence2 = string2.Split(" ");
            int occurrence = 0;
            for (int i = 0; i < sentence1.Length; i++)
            {
                for (int j = 0; j < sentence2.Length; j++)
                {
                    if (sentence1[i] == sentence2[j])
                    {
                        //occurrence of a word in a sentence 2
                        occurrence++;
                    }
                }
                Console.WriteLine($"Occurrence of word {sentence1[i]} from sentence1 in sentence2 = {occurrence}");
                occurrence = 0;
            }
        }
    }
}