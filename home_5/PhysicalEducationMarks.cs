using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
    public class PhysicalEducationMarks
    {

        public void PhysicalEducationlMarkCalculation(int physicalEducationlMark)
        {
            //Groups groups = new Groups();
           
            Student[] arrayOfStudentsInGroup = Groups.CreateGroup1();
            Student studentVsMaxMarkInGroup1 = GetPhysicalEducationMarkinGroup(arrayOfStudentsInGroup);
            Console.WriteLine($"Student vs Max PhysicalEducationMark in Groupe 1: {studentVsMaxMarkInGroup1.Name}. Mark: {studentVsMaxMarkInGroup1.MathMark}. Reward {studentVsMaxMarkInGroup1.Reward}");
         

            Student[] arrayOfStudentsInGroup2 = Groups.CreateGroup2();
            Student studentVsMaxMarkInGroup2 = GetPhysicalEducationMarkinGroup(arrayOfStudentsInGroup2);
            Console.WriteLine($"Student vs Max PhysicalEducationMark in Groupe 2: {studentVsMaxMarkInGroup2.Name}. Mark: {studentVsMaxMarkInGroup2.MathMark}. Reward {studentVsMaxMarkInGroup2.Reward}");

            Student[] arrayOfStudentsInGroup3 = Groups.CreateGroup3();
            Student studentVsMaxMarkInGroup3 = GetPhysicalEducationMarkinGroup(arrayOfStudentsInGroup3);
            Console.WriteLine($"Student vs Max PhysicalEducationMark in Groupe 3: {studentVsMaxMarkInGroup3.Name}. Mark: {studentVsMaxMarkInGroup3.MathMark}. Reward {studentVsMaxMarkInGroup3.Reward}");

            Student[] arrayOfAvrgMarkInGroup1 = Groups.CreateGroup1();
            double avrgPhysicalEducationMarkInGroup1 = AvrgPhysicalEducationMarkCalculation(arrayOfAvrgMarkInGroup1);
            Console.WriteLine($"PhysicalEducation Average in Group 1: {avrgPhysicalEducationMarkInGroup1}");

            Student[] arrayOfAvrgMarkInGroup2 = Groups.CreateGroup2();
            double avrgPhysicalEducationMarkInGroup2 = AvrgPhysicalEducationMarkCalculation(arrayOfAvrgMarkInGroup2);
            Console.WriteLine($"PhysicalEducation Average in Group 2: {avrgPhysicalEducationMarkInGroup2}");

            Student[] arrayOfAvrgMarkInGroup3 = Groups.CreateGroup3();
            double avrgPhysicalEducationMarkInGroup3 = AvrgPhysicalEducationMarkCalculation(arrayOfAvrgMarkInGroup3);
            Console.WriteLine($"PhysicalEducation Average in Group 3: {avrgPhysicalEducationMarkInGroup3}");

        }
        public double AvrgPhysicalEducationMarkCalculation(Student[] arrayOfAvrgMarkInGroup)
        {
            double summPhysicalEducationMark = 0;

            for (int i = 0; i < arrayOfAvrgMarkInGroup.Length; i++)
            {
                summPhysicalEducationMark += arrayOfAvrgMarkInGroup[i].MathMark;
            }
            double avrgPhysicalEducationMark = summPhysicalEducationMark / arrayOfAvrgMarkInGroup.Length;
            return avrgPhysicalEducationMark;
        }

        public Student GetPhysicalEducationMarkinGroup(Student[] arrayOfStudentsInGroup)
        {
            int maxMark = 0;
            Student studentVsMaxMark = new Student();
            for (int i = 0; i < arrayOfStudentsInGroup.Length; i++)
            {
                if (arrayOfStudentsInGroup[i].PhysicalEducationMark > maxMark)
                {
                    studentVsMaxMark = arrayOfStudentsInGroup[i];
                    maxMark = studentVsMaxMark.PhysicalEducationMark;
                }
            }
            return studentVsMaxMark;
        }

    }
}
