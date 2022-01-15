using System;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;


namespace myfirstapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Задание 1
            {
                Console.WriteLine("Ввежите произвольный набор данных"); //запрос данных
                string inputDAta = Console.ReadLine();//чтение данных
                File.WriteAllText(path: "example.txt", inputDAta);//запись данных в файл
                Console.WriteLine(File.Exists(path: "example.txt")); //проверка, что файл создан
                Console.ReadKey(); //Ожидание действия пользователя
            }
            
            //Задание 2
            {
                File.AppendAllText(path: "startup.txt", contents: DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                Console.WriteLine($"В файл добавлена следующая строка {DateTime.Now.ToString("HH:mm:ss")}");            
            }
            
            //Задание 3
            {
                Console.WriteLine("Введите с клавиатуры произвольный набор чисел от 0 до 255");
                string inputDAta = Console.ReadLine();
                string[] array = inputDAta.Split(' ');
                byte[] arrayb = new byte[array.Length];
                for (int i=0;i<array.Length;i++)
                {
                    arrayb[i] = Convert.ToByte(array[i]);
                }
                File.WriteAllBytes("bytes.bin", arrayb);
                Console.WriteLine("Файл записан");
                byte[] arrayf = File.ReadAllBytes("bytes.bin");
            }
            
            //Задание 4
            { 
                string path = DirectoryExists();
                Console.WriteLine("Как глубоко погружаемся? Введите число:");
                int depth = Convert.ToInt32(Console.ReadLine());
                string nameFile = "FilePath.txt";
                File.WriteAllText(nameFile, "");
                SaveTreePath(path, nameFile, "", depth);

            }
            
            //задание 5
            {
                ToDo toDo = new ToDo();
                if (toDo.fileExist)
                {
                    string json = File.ReadAllText("ToDo.json");
                    toDo = Newtonsoft.Json.JsonConvert.DeserializeObject<ToDo>(json);

                }
                toDo.Hello();
                while (true)
                {
                    string resume;
                    resume = toDo.Command(Console.ReadLine());
                    if (toDo.exit)
                    {
                        string jsonOut = JsonConvert.SerializeObject(toDo);
                        File.WriteAllText("ToDo.json",jsonOut);
                        Console.WriteLine(jsonOut);
                        Console.ReadLine();
                        break;
                    }
                }
            }

        }

        static string DirectoryExists()
        {
            Console.WriteLine("Введите существующий путь к папке:");
            string path;
            while (true)
            {
                path = Console.ReadLine();
                
                if (string.IsNullOrEmpty(path) || !Directory.Exists(path))
                {
                    Console.WriteLine("Введите корректный путь к папке");
                    continue;
                    
                }
                else
                {
                    return path;
                }
            }
        }

        static void SaveTreePath(string path, string nameFile, string otstup, int depth)
        {
            string[] entries = Directory.GetFileSystemEntries(path);
            foreach (string i in entries)
            {
                string text = otstup + Path.GetFileName(i);
                Console.WriteLine(text);
                File.AppendAllText(nameFile, text+Environment.NewLine);
                if (otstup.Length == depth) return;
                if (Directory.Exists(i))
                {
                    SaveTreePath(i, nameFile, otstup+"-", depth);
                }
            }
        }
    }
}
