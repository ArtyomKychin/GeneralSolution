using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
    public class MathMarks
    {

        public void MathMarkCalculation(int mathMark)
        {
            //Groups groups = new Groups();
          
            Student[] arrayOfStudentsInGroup1 = Groups.CreateGroup1();
            Student studentVsMaxMarkInGroup1 = GetMathMarkInGroup(arrayOfStudentsInGroup1);
            Console.WriteLine($"Student vs Max Math Mark in Groupe 1: {studentVsMaxMarkInGroup1.Name}. Mark: {studentVsMaxMarkInGroup1.MathMark}. Reward {studentVsMaxMarkInGroup1.Reward} ");
          
            Student[] arrayOfStudentsInGroup2 = Groups.CreateGroup2();
            Student studentVsMaxMarkInGroup2 = GetMathMarkInGroup(arrayOfStudentsInGroup2);
            Console.WriteLine($"Student vs Max Math Mark in Groupe 2: {studentVsMaxMarkInGroup2.Name}. Mark: {studentVsMaxMarkInGroup2.MathMark}. Reward {studentVsMaxMarkInGroup2.Reward}");

            Student[] arrayOfStudentsInGroup3 = Groups.CreateGroup3();
            Student studentVsMaxMarkInGroup3 = GetMathMarkInGroup(arrayOfStudentsInGroup3);
            Console.WriteLine($"Student vs Max Math Mark in Groupe 3: {studentVsMaxMarkInGroup3.Name}. Mark: {studentVsMaxMarkInGroup3.MathMark} Reward {studentVsMaxMarkInGroup3.Reward}");

            Student[] arrayOfGroup1 = Groups.CreateGroup1();
            double avrgMathMarkInGroup1 = AvrgMathMarkCalculation(arrayOfGroup1);
            Console.WriteLine($"Math Average in Group 1: {avrgMathMarkInGroup1}");

            Student[] arrayOfGroup2 = Groups.CreateGroup2();
            double avrgMathMarkInGroup2 = AvrgMathMarkCalculation(arrayOfGroup2);
            Console.WriteLine($"Math Average in Group 2: {avrgMathMarkInGroup2}");

            Student[] arrayOfGroup3 = Groups.CreateGroup3();
            double avrgMathMarkInGroup3 = AvrgMathMarkCalculation(arrayOfGroup3);
            Console.WriteLine($"Math Average in Group 3: {avrgMathMarkInGroup3}");
        }

        public double AvrgMathMarkCalculation(Student[] arrayOfGroup1)
        {
            double avrgMathMark = 0;
            double summMathMark = 0;

            for (int i = 0; i < arrayOfGroup1.Length; i++)
            {
                summMathMark += arrayOfGroup1[i].MathMark;
            }
            avrgMathMark = summMathMark / arrayOfGroup1.Length;
            return avrgMathMark;
        }

        public Student GetMathMarkInGroup(Student[] arrayOfStudentsInGroup)
        {
            int maxMark = 0;
            Student studentVsMaxMark = new Student();
            for (int i = 0; i < arrayOfStudentsInGroup.Length; i++)
            {
                if (arrayOfStudentsInGroup[i].MathMark > maxMark)
                {
                    studentVsMaxMark = arrayOfStudentsInGroup[i];
                    maxMark = studentVsMaxMark.MathMark;
                }
            }
            return studentVsMaxMark;
        }
    }
}
