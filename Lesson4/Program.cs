using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ArrayLibrary1;
using ArrayLibrary2;





namespace Lesson4
{
    static class MyArrayClass
    {
        public static int GetNumberOfPairs(int[] array)
        {
            int amountOfPairs = 0;
            try
                { 
                    for (int i = 0; i < array.Length; i++)
                        if (array[i]%3==0 && array[i+1]%3!=0)
                            amountOfPairs++;
                }
                catch
                {

                }
            return amountOfPairs;
        }
        public static int[] LoadFromFile(string filename)
        {
            int[]a;
            a = new int[0];
            try
            {
                StreamReader sr = new StreamReader(filename);
                int N = int.Parse(sr.ReadLine());
                a = new int[N];
                for (int i = 0; i < N; i++)
                {
                    a[i] = int.Parse(sr.ReadLine());
                }
                sr.Close();
            }
            catch (Exception exeption)
            {
               Console.WriteLine(exeption.Message);
            }
            return a;
        }
        

    }
    class Program
    {
        #region  Task 1
            // Автор: Эрнестас Рахмангуловас
            /*1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
             * Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
             * В данной задаче под парой подразумевается два подряд идущих элемента массива.
            */
            static void Task1()
            {
                Console.Clear();
                Console.WriteLine("1 Задание");
                int[] array1;
                array1 = new int[20];
                int min = -10000;
                int max = 10000;
                Random rnd = new Random();
                for (int i = 0; i < 20; i++)
                    array1[i] = rnd.Next(min,max);
                int count = 0;
                try
                { 
                    for (int i = 0; i < array1.Length; i++)
                        if (array1[i]%3==0 && array1[i+1]%3!=0)
                            count++;
                }
                catch
                {

                }
                
                Console.WriteLine("Количество пар элементов массива, в которых только одно число делится на 3 = " + count);
                Console.ReadKey();

            }


        #endregion
        #region  Task 2
            // Автор: Эрнестас Рахмангуловас
            /*2. Реализуйте задачу 1 в виде статического класса StaticClass;
                а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
                б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
                в)*Добавьте обработку ситуации отсутствия файла на диске.
            */
            static void Task2()
            {
                Console.Clear();
                Console.WriteLine("2 Задание");
                int[] array1;
                array1 = new int[20];
                int min = -10000;
                int max = 10000;
                Random rnd = new Random();
                for (int i = 0; i < 20; i++)
                        array1[i] = rnd.Next(min,max);
                Console.WriteLine("Количество пар элементов массива, в которых только одно число делится на 3 = " + MyArrayClass.GetNumberOfPairs(array1));
                
                
               

                Console.WriteLine("Для вывода данных из файла нажмите любую кнопку.");
                Console.ReadKey();
                int[]a;
                a = MyArrayClass.LoadFromFile("..\\..\\text.txt");
                for (int i = 0; i < a.Length; i++)
                
                Console.Write("{0}, ", a[i]);
                Console.ReadKey();
                

            }

        #endregion
        #region Task 3 
        // Автор: Эрнестас Рахмангуловас
        /*3.
        а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
        Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
        метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
        б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
        в) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
        */
            static int GetInt()
            {
                while (true)
                    if (!int.TryParse(Console.ReadLine(), out int x))
                        Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
                    else return x;
            }
            static void Task3()
            {
                Console.Clear();
                Console.WriteLine("3 Задание");
                Console.WriteLine("Вас приветствует программа демонстрации возможностей класса для работы с массивом");
                Console.Write("Введите желаемый размер массива: ");
                int size = GetInt();
                Console.Write("Введите первый элемент массива: ");
                int firstElement = GetInt();
                Console.Write("Введите шаг для добавления последующих элементов: ");
                int step = GetInt();
                MyArray a = new MyArray(size, firstElement, step);
                Console.WriteLine("\nСоздан массив: [ " + a.ToString() + " ]\n");
                Console.WriteLine("Сумма элементов массива: " + a.Sum);
                MyArray b = a.Inverse();
                Console.WriteLine("Массив с изменёнными знаками: [ " + b.ToString() + " ]\n");
                Console.Write("Введите число, на которое будут умножены элементы массива: ");
                a.Multi = GetInt();
                Console.WriteLine("Массив, умноженный на число: [ " + a.ToString() + " ]\n");
                Console.WriteLine("Максимальный элемент массива: " + a.Max);
                Console.WriteLine("Количество максимальных элементов массива: " + a.MaxCount);

                Console.ReadKey();
        }
        #endregion
        #region  Task 4
            // Автор: Эрнестас Рахмангуловас
            // 4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.Создайте структуру Account, содержащую Login и Password.

            struct Accout
            {
                public static string[] LoadFromFile(string filename)
                {
                    string[] a;
                    a = new string[100];
                    try
                    {
                        StreamReader sr = new StreamReader(filename);
                    
                        for (int i = 0; i < a.Length; i++)
                        {
                            a[i] = sr.ReadLine();
                        }
                        sr.Close();
                    }
                    catch (Exception exeption)
                    {
                        Console.WriteLine(exeption.Message);
                    }
                
                    return a;
                }
            }



            static void Task4()
            {
                Console.Clear();
                Console.WriteLine("4 Задание");
                int tryCount = 2;
                int re = 0;

                do
                {
                    Console.WriteLine("Для входа введите логин и пароль.");
                    Console.Write("Логин: ");
                    string user = Console.ReadLine();
                    Console.Write("Пароль: ");
                    string password = Console.ReadLine();

                    string[] a = Accout.LoadFromFile("..\\..\\UserInfo.txt");

                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] == null)
                            break;

                        int to = a[i].IndexOf(';');
                        string ausername = a[i].Substring(0, to);
                        string apassword = a[i].Substring(++to);
                        if (user == ausername && password == apassword)
                        {
                            Console.WriteLine("Вы вошли!");
                            Console.ReadKey();
                            re = 0;
                            break;
                        }
                        else
                            re++;
                                                                       
                    }
                    if (re++ > 0)
                    {
                        Console.WriteLine("Логин или пароль неверный! Попробуйте еще раз. Осталось попыток: " + tryCount);
                        Console.ReadKey();
                        tryCount--;
                    }
                    else
                        break;

                } while (tryCount >= 0);

            }
        #endregion
        #region Task 5
            // Автор: Эрнестас Рахмангуловас
            /*5.
                а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. 
                Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, 
                свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
                *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
                **в) Обработать возможные исключительные ситуации при работе с файлами.
            */

        
            static void Task5()
            {
                Console.Clear();
                Console.WriteLine("5 Задание");
                Console.WriteLine("Вас приветствует программа демонстрации возможностей класса для работы с двумерным массивом");
                Console.Write("Введите желаемое количество строк массива: ");
                int size1 = GetInt();
                Console.Write("Введите желаемое количество столбцов массива: ");
                int size2 = GetInt();
                            
                MyDimensionalArray a = new MyDimensionalArray(size1, size2);
                Console.WriteLine("\nСоздан массив: ");
                a.PrintDinArr(a.toString());
                long sum = 0;
                a.Sum(out sum);
                Console.WriteLine("Сумма элементов массива: " + sum);
                a.SumMoreThan(out sum, a.a[0, 0]);
                Console.WriteLine("Cумма элементов массива, которые больше, первого элемента: " + sum);
                Console.WriteLine("Максимальный элемент массива: " + a.Max);
                Console.WriteLine("Минимальный элемент массива: " + a.Min);
                string numOfMax = "";
                a.IndexOfMax(out numOfMax);
                Console.WriteLine("Номер максимального элемента: " + numOfMax);
                
                

                Console.ReadKey();
            }


        
            #endregion

            static void Main(string[] args)
            {
                start:
                Console.Clear();
                Console.WriteLine("Для выбора номера задания нажмите соответствующую кнопку:");
                Console.WriteLine(" 1 Задание: кнопка 1" + "\n 2 Задание: кнопка 2" + "\n 3 Задание: кнопка 3" + "\n 4 Задание: кнопка 4" + "\n 5 Задание: кнопка 5");
                ConsoleKeyInfo TaskNumber = Console.ReadKey();
                switch (TaskNumber.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Task1();
                        goto start;

                
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Task2();
                        goto start;
                
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Task3();
                        goto start;
                
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Task4();
                        goto start;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Task5();
                        goto start;
            
                }
            }
    } 
    
}


