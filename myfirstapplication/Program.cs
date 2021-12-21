using System;

namespace myfirstapplication
{
    class Program
    {
        enum mesEnum
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }

        static void Main(string[] args)
        {
            //Задача 1
            System.Console.WriteLine("Дробные числа необходимо вводить с разделителем системы, по умолчанию ','");
            System.Console.WriteLine("Введите минимальную температуру за сутки:");
            string tempMin = System.Console.ReadLine();
            System.Console.WriteLine("Введите максимальную температуру за сутки:");
            string tempMax = System.Console.ReadLine();
            //оказалось что конвертировать во float нельзя :(
            double tempMid = (Convert.ToDouble(tempMin) +Convert.ToDouble(tempMax))/2;
            System.Console.WriteLine($"Средняя температура за сутки {tempMid.ToString()} градуса");
            System.Console.ReadLine();
            //Задача 2
            System.Console.WriteLine("Введите порядковый номер текущего месяца");
            String monthNow = System.Console.ReadLine();
            switch (monthNow)
            {
                case "1":
                    System.Console.WriteLine("Январь");
                    break;
                case "2":
                    System.Console.WriteLine("Февраль");
                    break;
                case "3":
                    System.Console.WriteLine("Март");
                    break;
                case "4":
                    System.Console.WriteLine("Апрель");
                    break;
                case "5":
                    System.Console.WriteLine("Май");
                    break;
                case "6":
                    System.Console.WriteLine("Июнь");
                    break;
                case "7":
                    System.Console.WriteLine("Июль");
                    break;
                case "8":
                    System.Console.WriteLine("Август");
                    break;
                case "9":
                    System.Console.WriteLine("Сентябрь");
                    break;
                case "10":
                    System.Console.WriteLine("Октябрь");
                    break;
                case "11":
                    System.Console.WriteLine("Ноябрь");
                    break;
                case "12":
                    System.Console.WriteLine("Декабрь");
                    break;
                default:
                    System.Console.WriteLine("Нет месяца с таким порядковым номером");
                    return;

            }
            //вторая реализация, пришлось посмотреть шаблоны вывода
            if(Convert.ToInt32(monthNow) >12)
            {
                System.Console.WriteLine("Нет месяца с таким порядковым номером!");
                return;
            }
            DateTime WhatIsMonth = new DateTime(2015, Convert.ToInt32(monthNow),1);
            System.Console.WriteLine(WhatIsMonth.ToString("MMMM"));

            //третья реализация

            System.Console.WriteLine($"Текущий месяц {(mesEnum)Convert.ToInt32(monthNow)}");

            //Задача 3
            //Сделал допущение, что числа вводятся целые, маловероятно, что выйдем за пределы Int
            System.Console.WriteLine("Введите число:");
            int chislo= Convert.ToInt32(System.Console.ReadLine());
            bool chet = (chislo%2) == 0;
            if (chet) 
            {
                System.Console.WriteLine("Число четное!");
                System.Console.ReadLine();
            }
            else
            {
                System.Console.WriteLine("Число не четное!");
                System.Console.ReadLine();
            }
            
            //Задача 4

            DateTime tekTime = DateTime.Now;
            string stanciya = "МОСКВА ПАВЕЛЕЦКАЯ";
            string operatorKass = "Лазарева Е.С.";
            string idTranz = "АПБ-090М3 984 315";
            float stoimost = (float)80.0;
            string dokNum = "011872";
            System.Console.WriteLine("|---------------------|");
            System.Console.WriteLine("|АО ЦНТРАЛЬНАЯ ППК    |");
            System.Console.WriteLine($"|{stanciya}    |");
            System.Console.WriteLine($"|  {operatorKass}      |");
            System.Console.WriteLine($"|{idTranz}    |");
            System.Console.WriteLine("|                     |");
            System.Console.WriteLine("|                     |");
            System.Console.WriteLine($"|Итог            {stoimost}   |");
            System.Console.WriteLine("|                     |");
            System.Console.WriteLine($"|Документ №{dokNum}     |");
            System.Console.WriteLine("|                     |");
            System.Console.WriteLine("|---------------------|");

        }
    }
}