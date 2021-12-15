using System;

namespace myfirstapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите имя пользователя:");
            string userNAme = System.Console.ReadLine();
            System.Console.WriteLine($"Привет, {userNAme}, сегодня {System.DateTime.Now}!");
            System.Console.ReadLine();
        }
    }
}