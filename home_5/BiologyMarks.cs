using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
    public class BiologyMarks
    {
        //internal static BestBiologyMark studentVsMaxMark;

        public void BiologyMarkCalculation(int biologyMark)
        {
            //Groups groups = new Groups();

            Student[] arrayOfStudentsInGroup1 = Groups.CreateGroup1();
            Student studentVsMaxMarkInGroup1 = GetBiologyMarkInGroup(arrayOfStudentsInGroup1);
            Console.WriteLine($"Student vs Max Biology Mark in Groupe 1: {studentVsMaxMarkInGroup1.Name}. Mark: {studentVsMaxMarkInGroup1.BiologyMark}. Reward {studentVsMaxMarkInGroup1.Reward}");

            Student[] arrayOfStudentsInGroup2 = Groups.CreateGroup2();
            Student studentVsMaxMarkInGroup2 = GetBiologyMarkInGroup(arrayOfStudentsInGroup2);
            Console.WriteLine($"Student vs Max Biology Mark in Groupe 2: {studentVsMaxMarkInGroup2.Name}. Mark: {studentVsMaxMarkInGroup2.BiologyMark}. Reward {studentVsMaxMarkInGroup2.Reward}");

            Student[] arrayOfStudentsInGroup3 = Groups.CreateGroup3();
            Student studentVsMaxMarkInGroup3 = GetBiologyMarkInGroup(arrayOfStudentsInGroup3);
            Console.WriteLine($"Student vs Max Biology Mark in Groupe 3: {studentVsMaxMarkInGroup3.Name}. Mark: {studentVsMaxMarkInGroup3.BiologyMark}. Reward {studentVsMaxMarkInGroup3.Reward}");

            Student[] arrayOfGroup1 = Groups.CreateGroup1();
            double avrgBiologyMarkInGroup1 = AvrgMathMarkCalculation(arrayOfGroup1);
            Console.WriteLine($"Biology Average in Group 1: {avrgBiologyMarkInGroup1}");

            Student[] arrayOfGroup2 = Groups.CreateGroup2();
            double avrgBiologyMarkInGroup2 = AvrgMathMarkCalculation(arrayOfGroup2);
            Console.WriteLine($"Biology Average in Group 2: {avrgBiologyMarkInGroup2}");

            Student[] arrayOfGroup3 = Groups.CreateGroup3();
            double avrgBiologyMarkInGroup3 = AvrgMathMarkCalculation(arrayOfGroup3);
            Console.WriteLine($"Biology Average in Group 3: {avrgBiologyMarkInGroup3}");
        }

        public double AvrgMathMarkCalculation(Student[] arrayOfGroup1)
        {
            double avrgBiologyMark = 0;
            double summBiologyMark = 0;

            for (int i = 0; i < arrayOfGroup1.Length; i++)
            {
                summBiologyMark += arrayOfGroup1[i].MathMark;
            }
            avrgBiologyMark = summBiologyMark / arrayOfGroup1.Length;
            return avrgBiologyMark;
        }

        public Student GetBiologyMarkInGroup(Student[] arrayOfStudentsInGroup)
        {
            int maxMark = 0;
            Student studentVsMaxMark = new Student();
            for (int i = 0; i < arrayOfStudentsInGroup.Length; i++)
            {
                if (arrayOfStudentsInGroup[i].BiologyMark > maxMark)
                {
                    studentVsMaxMark = arrayOfStudentsInGroup[i];
                    maxMark = studentVsMaxMark.BiologyMark;
                }
            }
            return studentVsMaxMark;
        }

    }
}
