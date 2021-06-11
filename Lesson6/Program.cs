using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson6
{
    class Program
    {


        #region 1 Задание

        // Эрнестас Рахмангуловас
        /*1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
         * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
        */
        public delegate double Fun(double a, double x);

        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- A ----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("------------------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

        public static double MySinFunc(double a, double x)
        {
            return a * Math.Sin(x);
        }
        static void Task1()
        {
            Console.Clear();
            Console.WriteLine("1 Задание");


            Console.WriteLine("Таблица функции a*x^2:");
            Table(MyFunc, 2, 2, 10);
            Console.WriteLine("Таблица функции a*sin(x):");
            Table(MySinFunc, 2, 2, 10);

            Console.ReadKey();

        }
        #endregion
        #region 2 Задание
        /* Эрнестас Рахмангуловас
        2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
            а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. 
            Использовать массив (или список) делегатов, в котором хранятся различные функции.
            б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. 
            Пусть она возвращает минимум через параметр (с использованием модификатора out).
        */
        public delegate double Func(double x);

        static void Table2(double start, double end, double step, double[] values)
        {
            Console.WriteLine("------- X ------- Y -----");
            int index = 0;
            while (start <= end)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} ", start, values[index]);
                start += step;
                index++;
            }
            Console.WriteLine("--------------------------");
        }

        public static double Degree(double x)
        {
            return x * x;
        }
        public static double ThirdDegree(double x)
        {
            return x * x * x;
        }
        public static double Sin(double x)
        {
            return Math.Sin(x);
        }
        static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
        static int GetInt(int max)
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x) || x > max)
                    Console.Write("Неверный ввод (требуется числовое значение от 0 до {0}).\nПожалуйста повторите ввод: ", max);
                else return x;
        }
        static void GetInterval(out double start, out double end)
        {
            string[] interval = Console.ReadLine().Split(' ');
            start = double.Parse(interval[0], CultureInfo.InvariantCulture);
            end = double.Parse(interval[1], CultureInfo.InvariantCulture);
        }
        public static void SaveFunc(string fileName, double start, double end, double step, Func F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            while (start <= end)
            {
                bw.Write(F(start));
                start += step;
            }
            bw.Close();
            fs.Close();
        }


        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] array = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {

                d = bw.ReadDouble();
                array[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return array;
        }

        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("2 Задание");

            Console.WriteLine("Вас приветсвует программа нахождения минимума функции!");
            List<Func> functions = new List<Func> { new Func(Degree), new Func(ThirdDegree), new Func(Sqrt), new Func(Sin) };
            Console.WriteLine("Выберите функцию для дальнейшей работы.");
            Console.WriteLine("1) f(x)=y^2");
            Console.WriteLine("2) f(x)=y^3");
            Console.WriteLine("3) f(x)=y^1/2");
            Console.WriteLine("4) f(x)=Sin(y)");
            int userChoose = GetInt(functions.Count);

            Console.WriteLine("Задайте отрезок для нахождения минимума в формате 'х1 х2':");

            double start = 0;
            double end = 0;
            GetInterval(out start, out end);
            double min = double.MaxValue;

            Console.WriteLine("Задайте величинау шага дискредитирования:");
            double step = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SaveFunc("data.bin", start, end, step, functions[userChoose - 1]);

            Console.WriteLine("Получены следующие значения функции: ");
            Table2(start, end, step, Load("data.bin", out min));
            Console.WriteLine("Минимальное значение функции равняется: {0:0.00}", min);
            Console.ReadKey();

        }
        #endregion
        #region 3 Задание
        // Эрнестас Рахмангуловас
        /*3. Переделать программу Пример использования коллекций для решения следующих задач:
            а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
            в) отсортировать список по возрасту студента;
            г) *отсортировать список по курсу и возрасту студента;
        */
        static int AgeCompare(Student st1, Student st2)
        {
            return String.Compare(st1.age.ToString(), st2.age.ToString());
        }

        static int CourceAndAgeCompare(Student st1, Student st2)
        {
            if (st1.course > st2.course)
                return 1;
            if (st1.course < st2.course)
                return -1;
            if (st1.age > st2.age)
                return 1;
            if (st1.age < st2.age)
                return -1;
            return 0;
        }
        class Student
        {
            public string lastName;
            public string firstName;
            public string university;
            public string faculty;
            public int course;
            public string department;
            public int group;
            public string city;
            public int age;

            public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
            {
                this.lastName = lastName;
                this.firstName = firstName;
                this.university = university;
                this.faculty = faculty;
                this.department = department;
                this.course = course;
                this.age = age;
                this.group = group;
                this.city = city;
            }
        }

        static void Task3()
        {
            Console.Clear();
            Console.WriteLine("3 Задание");

            int magistr1 = 0;
            int magistr2 = 0;
            List<Student> list = new List<Student>();
            DateTime dt = DateTime.Now;
            Dictionary<int, int> cousreFrequency = new Dictionary<int, int>();
            StreamReader sr = new StreamReader("..\\..\\StudentsInfo.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');

                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));

                    if (int.Parse(s[6]) == 5) magistr1++; else if (int.Parse(s[6]) == 6) magistr2++;
                    if (int.Parse(s[5]) > 17 && int.Parse(s[5]) < 21)
                    {
                        if (cousreFrequency.ContainsKey(int.Parse(s[6])))
                            cousreFrequency[int.Parse(s[6])] += 1;
                        else
                            cousreFrequency.Add(int.Parse(s[6]), 1);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");

                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров первого курса:{0}", magistr1);
            Console.WriteLine("Магистров второго курса:{0}", magistr2);
            Console.WriteLine("\nПокажем сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся.");
            ICollection<int> keys = cousreFrequency.Keys;
            String result = String.Format("{0,-10} {1,-10}\n", "Курс", "Количество студентов");
            foreach (int key in keys)
                result += String.Format("{0,-10} {1,-10:N0}\n",
                                   key, cousreFrequency[key]);
            Console.WriteLine($"\n{result}");

            list.Sort(new Comparison<Student>(AgeCompare));
            Console.WriteLine("Отсортируем студентов по возрасту: ");
            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age}");

            list.Sort(new Comparison<Student>(CourceAndAgeCompare));
            Console.WriteLine("\nОтсортируем студентов по курсу и возрасту возрасту: ");
            foreach (var v in list) Console.WriteLine($"{v.firstName}, курс {v.course}, возраст {v.age}");

            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
        #endregion
        static void Main(string[] args)
        {
        start:
            Console.Clear();
            Console.WriteLine("Для выбора номера задания нажмите соответствующую кнопку:");
            Console.WriteLine(" 1 Задание: кнопка 1" + "\n 2 Задание: кнопка 2" + "\n 3 Задание: кнопка 3");
            ConsoleKeyInfo TaskNumber = Console.ReadKey();
            switch (TaskNumber.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine();
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


            }
        }
    }
}
