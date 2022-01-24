using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStartField();
            string t = Properties.Settings.Default.SayStart;
            Console.WriteLine(t);
            string name = InputData("Введите своё имя:");
            string year = InputData("Введите свой возраст:");
            string work = InputData("Введите свой род деятельности:");
            Properties.Settings.Default.Name = name;
            Properties.Settings.Default.Year = year;
            Properties.Settings.Default.Work = work;
            Properties.Settings.Default.Save();

        }

        static string InputData (string txt)
        {
            Console.WriteLine(txt);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                return "no data";
            }
            return input;
        }
        static void TestStartField()
        {
            Console.WriteLine("Данные введенные в прошлый запуск:");
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Name))
            {
                Console.WriteLine($"Ваше имя: {Properties.Settings.Default.Name}");
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Year))
            {
                Console.WriteLine($"Ваш возраст: {Properties.Settings.Default.Year}");
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Work))
            {
                Console.WriteLine($"Ваше род деятельности: {Properties.Settings.Default.Work}");
            }
        }
    }
}
