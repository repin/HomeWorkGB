using System;

namespace myfirstapplication
{
    class Program
    {
        enum season
        {
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4
        }
        static void Main(string[] args)
        {
            //задание 1
            {
                string[] Name;
                string[] LastName;
                string[] Paronymc;
                Name = GetMassive("Вася", "Петя", "Дима");
                LastName = GetMassive("Иванов", "Петров", "Сидовров");
                Paronymc = GetMassive("Владимирович", "Инокеньтьевич", "Абрамович");
                for (int i = 0; i < Name.Length; i++)
                {
                    string FullName = GetFullName(Name[i], LastName[i], Paronymc[i]);
                    Console.WriteLine($"ФИО: {FullName}");
                }
                Console.ReadLine();

            }
            //Задание 2
            {
                Console.WriteLine("Введите цифры через пробел:");
                string txt = Console.ReadLine();
                int itog = 0;
                string sItog = "";
                for (int i = 0; i < txt.Length; i++)
                {
                    if (isProbel(txt[i]))
                    {
                        itog += Convert.ToInt32(sItog);
                        sItog = "";
                    }
                    else
                    {
                        sItog = sItog + txt[i];
                    }
                }
                itog += Convert.ToInt32(sItog);
                Console.WriteLine(itog);
                Console.ReadLine();
            }
            //Задание 3
            {
                Console.WriteLine("Введите номер месяца");
                string month = "";
                do
                {
                    month = Console.ReadLine();
                } while (CheckInput(month));
                string numberSeason = GetSeasonNumber(month);
                ConsoleWriteSeasonName(numberSeason);
            }

            //Задание 4
            {
                Console.WriteLine("Введите число для расчета");
                string getConsoleWrite = Console.ReadLine();
                Fibonachi(Convert.ToInt32(getConsoleWrite));
            }

        }

        static void Fibonachi(int z)
        {
            FibonachiRaschet(0, 1, 0, z);
            Console.ReadLine();
        }

        static void FibonachiRaschet(long a, long b, long i, long max)
        {
            if (i == max + 1) return;
            i++;
            long c = a + b;
            Console.Write($" {a}");
            FibonachiRaschet(b, c, i, max);
            return;
        }

        static void ConsoleWriteSeasonName(string numberSeason)
        {
            switch (numberSeason)
            {
                case "Winter":
                    Console.WriteLine("Зима");
                    break;
                case "Spring":
                    Console.WriteLine("Весна");
                    break;
                case "Summer":
                    Console.WriteLine("ЗЛето");
                    break;
                case "Autumn":
                    Console.WriteLine("Осень");
                    break;
            }
        }

        static string GetSeasonNumber(string month)
        {
            int numberSeason = 0;
            switch (month)
            {
                case "1":
                case "2":
                    numberSeason = 1;
                    break;
                case "3":
                case "4":
                case "5":
                    numberSeason = 2;
                    break;
                case "6":
                case "7":
                case "8":
                    numberSeason = 3;
                    break;
                case "9":
                case "10":
                case "11":
                    numberSeason = 4;
                    break;
                case "12":
                    numberSeason = 1;
                    break;
            }
            season whatisseason = (season)numberSeason;
            return whatisseason.ToString();
        }

        static bool CheckInput(string month)
        {
            bool value = true;
            if (string.IsNullOrEmpty(month))
            {
                Console.WriteLine("Ошибка, ввелите число от 1 до 12");
                return value;

            }
            if (Convert.ToInt32(month) > 12 || Convert.ToInt32(month) < 1)
            {
                Console.WriteLine("Ошибка, ввелите число от 1 до 12");
            }
            else
            {
                value = false;
            }

            return value;
        }
        static string GetFullName(string FirstName, string LastName, string paronymc)
        {
            string FullName = $"{FirstName} {LastName} {paronymc}";
            return FullName;
        }


        static string[] GetMassive(string one, string two, string tree)
        {
            string[] x = new string[3];
            x[0] = one;
            x[1] = two;
            x[2] = tree;
            return x;
        }
        static bool isProbel(char chari)
        {
            return chari == ' ' ? true : false;


        }
    }
}
