using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
    public class Groups
    {
        public Student[] CreateGroupByNumber(int number)
        {
            switch (number)
            {
                case 1:
                    {
                        return CreateGroup1();
                    }
                case 2:
                    {
                        return CreateGroup2();
                    }
                case 3:
                    {
                        return CreateGroup3();
                    }
            }
            return (new Student[4]);
        }

        public static Student[] CreateGroup1()
        {
            Student[] arrayOfGroup1 = new Student[5];
            string[] names = { "Anna", "Tanya", "Julia", "Emilia", "Mary" };
            int[] mathMark1 = new int[5];
            Random random = new Random();
            int id1 = 0;

            for (int i = 0; i < arrayOfGroup1.Length; i++)
            {
                id1++;
                int age = random.Next(18, 21);
                mathMark1[i] = random.Next(1, 10);
                int physicalEducationMark = random.Next(1, 10);
                int biologyMark = random.Next(1, 10);
                int reward = random.Next(1, 100);
                arrayOfGroup1[i] = new Student(id1, names[i], age, "Group1", mathMark1[i], physicalEducationMark, biologyMark, reward);
            }
            return arrayOfGroup1;
            
        }
        public static Student[] CreateGroup2()
        {
            Student[] arrayOfGroup2 = new Student[5];
            string[] names = { "John", "Jack", "Harry", "Robert", "Stive" };
            Random random = new Random();
            int id2 = 5;
            for (int i = 0; i < arrayOfGroup2.Length; i++)
            {
                id2++;
                int age = random.Next(18, 21);
                int mathMark = random.Next(1, 10);
                int physicalEducationMark = random.Next(1, 10);
                int biologyMark = random.Next(1, 10);
                int reward = random.Next(1,100);
                arrayOfGroup2[i] = new Student(id2, names[i], age, "Group2", mathMark, physicalEducationMark, biologyMark, reward);
            }
            return arrayOfGroup2;
        }

        public static Student[] CreateGroup3()
        {
            Student[] arrayOfGroup3 = new Student[5];
            string[] names = { "ALice", "Sophia", "Katherine", "Victoria", "Diana" };
            Random random = new Random();
            int id3 = 10;
            for (int i = 0; i < arrayOfGroup3.Length; i++)
            {
                id3++;
                int age = random.Next(18, 21);
                int mathMark = random.Next(1, 10);
                int physicalEducationMark = random.Next(1, 10);
                int biologyMark = random.Next(1, 10);
                int reward = random.Next(1, 100);
                arrayOfGroup3[i] = new Student(id3, names[i], age, "Group3", mathMark, physicalEducationMark, biologyMark, reward);
            }
            return arrayOfGroup3;
        }
    }


}
