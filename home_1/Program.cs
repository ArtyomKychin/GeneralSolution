﻿using System;

namespace HomeApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();//ввод имени 
            Console.WriteLine("Введите вашу фамилию");
            string surname = Console.ReadLine();//ввод фамилии
            Console.WriteLine("Hello " + name + " " + surname + "!");
            Console.WriteLine("Для закрытия окна нажмите любую клавишу");
            Console.ReadKey();//ожмдание нажатия любой кнопки
            //ДЗ на проверку
        }
    }
}