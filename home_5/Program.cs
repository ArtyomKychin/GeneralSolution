using System;

namespace home_5
{
    public class Program
    {
        static void Main(string[] args)
        {

            
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("All Students and All Marks:");
            Groups studentsGroupe1 = new Groups();
            Student[] arrayOfGroup1 = studentsGroupe1.CreateGroup1();
            StudentDisplayer sd1 = new();
            sd1.DysplayGroupe1(arrayOfGroup1);

            Groups studentGroup2 = new Groups();
            Student[] arrayOfGroup2 = studentGroup2.CreateGroup2();
            StudentDisplayer sd2 = new ();
            sd2.DysplayGroup2(arrayOfGroup2);

            Groups studentGroup3 = new Groups();
            Student[] arrayOfGroup3 = studentGroup3.CreateGroup2();
            StudentDisplayer sd3 = new();
            sd3.DysplayGroup3(arrayOfGroup3);
        }

    }
}