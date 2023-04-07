namespace HomeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task0();
            Task2();
            Task3();
            Task4();
        }
             public static void Task0()

               {
                   Console.WriteLine("Enter a number to check");
                   int num = Convert.ToInt16(Console.ReadLine());
                   int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
                   bool flag = false;

                   for (int i = 0; i < numbers.Length; i++)
                   {
                       if (numbers[i] == num)
                       {
                           flag = true;
                       }
                   }
                   if (flag)
                   {
                       Console.WriteLine("Your number is in the array");
                   }
                   else
                       Console.WriteLine("Your number is not in the array");
               }
       
        public static void Task2()

        {
            Console.WriteLine("Enter the size of the array");

            Random random = new Random();
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            int maxvalue = int.MinValue;
            int minvalue = int.MaxValue;
            int sum = 0;

            Console.WriteLine($"An array of the specified size{size} has been created\nTo display the array on the screen, press any button");
            Console.ReadKey();
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
                Console.Write(array[i] + " \n");
                if (maxvalue < array[i])
                {
                    maxvalue = array[i];
                }
                if (minvalue > array[i])
                {
                    minvalue = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.Write($"Max value in array: { maxvalue }\nMin value in array: {minvalue}\nAverage value in the array: {sum / size }\n");
        }

        public static void Task3()

        {
            Random random = new Random();
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int sum1 = 0;
            int sum2 = 0;
            
            Console.WriteLine("Array1:");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next();
                sum1 += array1[i];
                Console.Write(array1[i] + " ");
            }
            int avrg1 = sum1 / array1.Length;
            Console.WriteLine("\n");
            Console.WriteLine("Array2:");
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = random.Next();
                sum2 += array2[i];
                Console.Write(array2[i] + " ");
            }
            int avrg2 = sum2 / array2.Length;
            Console.WriteLine("\n");
            if (avrg1 > avrg2) 
            {
                Console.WriteLine($"average value in the array1 {avrg1} is greater than in array 2 {array2}");
            }
            if(avrg1 == avrg2)
            {
                Console.WriteLine($"average value of array1 {avrg1} is equal to the average value of array 2 {array2}");
            }
            if(avrg1 < avrg2)
            {
                Console.WriteLine($"average value in the array1 { avrg1 } is less than in array2 { avrg2 }");
                Console.WriteLine("\n");
            }
        }
        public static void Task4()

        {
            Random random = new Random();
            int[] array = new int[5];
            Console.Write("Source array:\n");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
            //create an array
            Console.WriteLine("Resulting array:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[i] = array[i];
                }
                if (array[i] % 2 != 0)
                {
                    array[i] = 0;
                }
                Console.Write(array[i] + " ");
            }
        }
    }
}