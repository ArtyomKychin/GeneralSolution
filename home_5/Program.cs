using System;

namespace home_5
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            
            MathMarks mathMark = new();
            mathMark.MathMarkCalculation(0);
            
            PhysicalEducationMarks physicalEducationMark = new();
            physicalEducationMark.PhysicalEducationlMarkCalculation(0);

            BiologyMarks biologyMark = new();
            biologyMark.BiologyMarkCalculation(0);

            Console.SetCursorPosition(0, 20);
            Console.WriteLine("All Students and All Marks:");
            Groups studentGroupe1 = new Groups();
            Student[] arrayOfGroup1 = studentGroupe1.CreateGroupByNumber(1);
            StudentDisplayer sd1 = new();
            sd1.DysplayGroupe1(arrayOfGroup1);

            Groups studentGroup2 = new Groups();
            Student[] arrayOfGroup2 = studentGroup2.CreateGroupByNumber(2);
            StudentDisplayer sd2 = new();
            sd2.DysplayGroup2(arrayOfGroup2);

            Groups studentGroup3 = new Groups();
            Student[] arrayOfGroup3 = studentGroup3.CreateGroupByNumber(3);
            StudentDisplayer sd3 = new();
            sd3.DysplayGroup3(arrayOfGroup3);
        }

    }
}