using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
    public class StudentDisplayer
    {
        public void DysplayGroupe1(Student[] arrayOfGroup1)
        {
            foreach (Student groupe1 in arrayOfGroup1)
            {
                Console.Write($"Student ID: {groupe1.Id}, name: {groupe1.Name}, Age: {groupe1.Age}, {groupe1.Group} ");
                Console.WriteLine($"MathMark: {groupe1.MathMark}, PhysicalEducationMark: {groupe1.PhysicalEducationMark}, biologyMark: {groupe1.BiologyMark}");
            }
        }
        public void DysplayGroup2(Student[] arrayOfGroup2)
        {
            foreach (Student groupe2 in arrayOfGroup2)
            {
                Console.Write($"Student ID: {groupe2.Id}, name: {groupe2.Name}, Age: {groupe2.Age}, {groupe2.Group} ");
                Console.WriteLine($"MathMark: {groupe2.MathMark}, PhysicalEducationMark: {groupe2.PhysicalEducationMark}, biologyMark: {groupe2.BiologyMark}");
            }
        }
        public void DysplayGroup3(Student[] arrayOfGroup3)
        {
            foreach (Student groupe3 in arrayOfGroup3)
            {
                Console.Write($"Student ID: {groupe3.Id}, name: {groupe3.Name}, Age: {groupe3.Age}, {groupe3.Group} ");
                Console.WriteLine($"MathMark: {groupe3.MathMark}, PhysicalEducationMark: {groupe3.PhysicalEducationMark}, biologyMark: {groupe3.BiologyMark}");
            }
        }
    }
}
