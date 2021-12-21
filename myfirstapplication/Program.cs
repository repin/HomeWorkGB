using System;

namespace myfirstapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Дробные числа необходимо вводить с разделителем системы, по умолчанию ','");
            System.Console.WriteLine("Введите минимальную температуру за сутки:");
            string tempMin = System.Console.ReadLine();
            System.Console.WriteLine("Введите максимальную температуру за сутки:");
            string tempMax = System.Console.ReadLine();
            double tempMid = (Convert.ToDouble(tempMin) +Convert.ToDouble(tempMax))/2;
            System.Console.WriteLine($"Средняя температура за сутки {tempMid.ToString()} градуса");
            System.Console.ReadLine();
        }
    }
}