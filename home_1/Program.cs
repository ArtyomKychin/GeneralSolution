using System;

namespace HomeApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string user = Console.ReadLine();//ввод имени пользователя
            Console.WriteLine("Hello " + user +"!");
            Console.WriteLine("Для закрытия окна нажмите любую клавишу");
            Console.ReadKey();//ожмдание нажатия люой кнопки
        }
    }
}