using System;

namespace myfirstapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //новый коммент для пул реквеста ><
                //задание №2: телефонный справочник
                string[][] telKniga = new string[5][];
                for (int i = 0; i < telKniga.Length; i++) telKniga[i] = new string[2];
                telKniga[0][0] = "Иванов Иван Иванович";
                telKniga[0][1] = "+7-777-777-77-77";
                telKniga[1][0] = "Петров Петр Петрович";
                telKniga[1][1] = "+8-777-777-77-77";
                telKniga[2][0] = "Алексейв Алексей Алексеевич";
                telKniga[2][1] = "+9-777-777-77-77";
                telKniga[3][0] = "Дмитриев Дмитрий Дмитриевич";
                telKniga[3][1] = "+3-777-777-77-77";
                telKniga[4][0] = "Кваснов Игорь Сергеевич";
                telKniga[4][1] = "+4-777-777-77-77";
                for (int i = 0; i < telKniga.Length; i++)
                {
                    Console.WriteLine($"Запись №{i}: ");
                    Console.WriteLine($"ФИО: {telKniga[i][0]}, телефон: {telKniga[i][1]}");
                }
                Console.ReadLine();
            }

            //Задание №1: Вывод значений двумерного массива по диагонали
            //исходя из комментов в телеграмме похоже я ТЗ неправильно понял :D
            //и надо выводить было просто значения из массива 


            {
                int[,] array = new int[3, 3];
                array[0, 0] = 1;
                array[0, 1] = 2;
                array[0, 2] = 7;
                array[1, 0] = 3;
                array[1, 1] = 4;
                array[1, 2] = 8;
                array[2, 0] = 5;
                array[2, 1] = 6;
                array[2, 2] = 9;

                int leghtArray = array.Length;
                int k = 0,
                    l = 0,
                    d = 0;
                for (int i = 0; i < leghtArray; i++)
                {
                    for (int j = 0; j < leghtArray; j++)
                    {
                        if (i == j)
                        {
                            Console.Write(array[k, l] + " ");
                            if (l < array.GetLength(1) - 1)
                            {
                                l++;
                            }
                            else
                            {
                                k++;
                                l = 0;
                            }

                        }
                        else
                        {
                            Console.Write(" " + " ");
                        }

                    }
                    Console.WriteLine();
                }
                Console.ReadLine();

            }


            //Задача 3
            {
                Console.WriteLine("Введите строку:");
                string text = Console.ReadLine();
                for (int i = text.Length - 1; i != -1; --i)
                {
                    Console.Write(text[i]);
                }
                Console.ReadLine();
            }


            //Задача 4, попробовал выводить корабли относительно случайно, с использованием мс из времени
            {
                string[,] pole = new string[10, 10];
                for (int i = 0; i < pole.GetLength(0); i++)
                {
                    int k = DateTime.Now.Millisecond;
                    k = k - (int)(k / 10) * 10;
                    for (int j = 0; j < pole.GetLength(1); j++)
                    {
                        pole[i, j] = "O";
                        if (j == k || (i == k / 2 && i == j) || (i == k / 3 && i == j))
                        {
                            pole[i, j] = "X";

                        }
                        Console.Write($"{pole[i, j]} ");
                    }
                    Console.WriteLine();
                }

                //тут начинается код автоматической игры компа )
                //Комп не видит поле и выбирает случайное место
                //Если в случайном месте есть корабль - то стреляет иставит P - popal, если корабля нет - ставит M - mimo
                //Если попадает в поле, куда уже стрелял, то начинает перебором искать поле, в которое ещё не стрелял и стреляет в него
                //По итогу выводит информацию в консоль по шагам и матрицу выстрелов :) (делал в последний момент, поэтому не оптимизировал алгоритм, но по анализу все определяет правильно
                string fight = "";
                while (fight != "д" || fight != "н")
                {
                    Console.WriteLine("Запустить автоматический бой? (д\\н)");

                    fight = Console.ReadLine();
                    if (fight == "д")
                    {

                        bool opt = true;
                        while (opt)
                        {

                            int n = DateTime.Now.Millisecond;
                            int p = (int)(n / 10) - (int)(n / 100) * 10; //получаем случайное значение р
                            n = n - (int)(n / 10) * 10; //получаем случайное значение n
                            if (pole[n, p] == "X") //стреляем в случайном месте, смотрим есть ли там корабль, если есть - помечаем попадание
                            {
                                Console.WriteLine($"Попадание в цель по адресу: {n} {p}");
                            }
                            else if (pole[n, p] == "O")
                            {
                                Console.WriteLine($"Промазали по адресу: {n} {p}");
                                pole[n, p] = "M";
                            }
                            else
                            {
                                int z = 100;
                                while (opt)
                                {

                                    if (n == 10)
                                    {
                                        n = 0;
                                        p++;
                                    }
                                    if (p == 10)
                                    {
                                        p = 0;

                                    }
                                    if (pole[n, p] == "X")
                                    {
                                        pole[n, p] = "P";
                                        Console.WriteLine($"Попадание цель по адресу: {n} {p}");
                                        break;
                                    }
                                    else if (pole[n, p] == "O")
                                    {
                                        Console.WriteLine($"Промазали по адресу: {n} {p}");
                                        pole[n, p] = "M";
                                    }
                                    else
                                    {
                                        n++;
                                    }
                                    if (z == 0)
                                    {
                                        Console.WriteLine("Поиск кораблей закончен");
                                        opt = false;
                                        break;
                                    }
                                    z--;
                                }
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                Console.Write(pole[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else if (fight == "н")
                    {
                        break;
                    }
                }

            }

        }
    }
}