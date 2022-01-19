using System;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using System.Diagnostics;


namespace myfirstapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Process[] process = Process.GetProcesses();
            Console.WriteLine("Вы можете закрыть процесс по имени или ID:");
            Console.WriteLine("Все системые процессы:");
            string inputText;
            foreach (Process k in process)
            {
                Console.WriteLine($"{k.Id} {k.ProcessName}");
                
            }
            Console.WriteLine("Введите имя процесс`а или ID для закрытия процесса:");
            inputText = Console.ReadLine();
            //первый вариант
            try
            {
                int k = Convert.ToInt32(inputText);
                Process killProcess = Process.GetProcessById(k);
                killProcess.Kill();
            }
            catch
            {
               Process[] killProcess= Process.GetProcessesByName(inputText);
                foreach (Process z in killProcess)
                {
                    z.Kill();
                }
            }
            

            //второй вариант
          /*  foreach (Process k in process)
            {
                if (k.ProcessName == inputText || k.Id.ToString() == inputText)
                {
                    k.Kill();
                }
                
            }*/
       }
    }
}
