using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Автор: Эрнестас Рахмангуловас
namespace Lesson2
{
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }
        #region 1 Задание
        // Автор: Эрнестас Рахмангуловас
        // 1. Написать метод, возвращающий минимальное из трёх чисел.
        static void Task1()
        {

            Console.Clear();
            int a, b, c, min;
            Console.WriteLine("1 Задание");
            Console.WriteLine("Введите три целых числа.");
            Console.Write("Первое число: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Третье число: ");
            c = int.Parse(Console.ReadLine());
            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < a && b < c)
            {
                min = b;
            }
            else
            {
                min = c;
            }
            Console.WriteLine("Наименьшее число {0}", min);
            Console.WriteLine("Для возврата к выбору задания нажмите любую кнопку...");
            Pause();


        }
        #endregion
        #region 2 Задание
        // Автор: Эрнестас Рахмангуловас
        // 2. Написать метод подсчета количества цифр числа.
        static void Task2()
        {
            Console.Clear();
            long x, count;
            Console.WriteLine("2 Задание");
            Console.Write("Введите целое число: ");
            x = long.Parse(Console.ReadLine());
            for (count = 0; x > 0; count++)
            {
                x = x / 10;
            }
            Console.WriteLine("Количество цифр в числе = " + count);
            Console.WriteLine("Для возврата к выбору задания нажмите любую кнопку...");
            Pause();

        }

        #endregion
        #region 3 Задание
        // Автор: Эрнестас Рахмангуловас
        // 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел. 

        static void Task3()
        {
            Console.Clear();
            long a, sum = 0;
            Console.WriteLine("3 Задание");
            do
            {
                Console.Write("Введите произвольное число:");
                a = long.Parse(Console.ReadLine());
                if (a % 2 == 1)
                {
                    sum = sum + a;
                }

            }
            while (a > 0);

            Console.WriteLine("Сумма всех нечетных положительных чисел = " + sum);
            Console.WriteLine("Для возврата к выбору задания нажмите любую кнопку...");
            Pause();
        }


        #endregion
        #region 4 Задание
        // Автор: Эрнестас Рахмангуловас
        // 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
        // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
        // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        // С помощью цикла do while ограничить ввод пароля тремя попытками.
        static void Task4()
        {
            Console.Clear();
            string user1 = "root";
            string password1 = "GeekBrains";
            int tryCount = 2;

            do
            {
                Console.Clear();
                Console.WriteLine("Для входа введите логин и пароль.");
                Console.Write("Логин: ");
                string user = Console.ReadLine();
                Console.Write("Пароль: ");
                string password = Console.ReadLine();
                if (user == user1 && password == password1)
                {
                    Console.WriteLine("Вы вошли!");
                    Pause();
                    break;
                }
                else
                {
                    Console.WriteLine("Логин или пароль неверный! Попробуйте еще раз. Осталось попыток: " + tryCount);
                    Pause();
                    tryCount--;
                }
            }
            while (tryCount >= 0);

            Console.WriteLine("Для возврата к выбору задания нажмите любую кнопку...");
            Pause();


        }

        #endregion
        #region 5 Задание
        // Автор: Эрнестас Рахмангуловас
        //5. 
        //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
        //нужно ли человеку похудеть, набрать вес или всё в норме.
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        static void Task5()
        {
            Console.Clear();
            Console.WriteLine("Для расчета ИМТ введите:");
            Console.Write("Введите ваш вес в килограммах: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш рост в сантиметрах: ");
            double height = double.Parse(Console.ReadLine());
            double i, min, max, ideal;
            height = height / 100;
            i = weight / (height * height);
            min = 18.5 * (height * height);
            max = 24.9 * (height * height);
            if (i >= 18.5 && i < 25)
            {
                Console.WriteLine($"Ваш вес в норме, ИМТ-{i:N2}");
                Pause();
            }
            else if (i < 18.5)
            {
                Console.WriteLine($"Вам нужно набрать вес, ИМТ-{i:N2}");
                ideal = min - weight;
                Console.WriteLine($"Вам нужно набрать {ideal:N2} кг для нормализации веса");
                Pause();
            }
            else if (i >= 25)
            {
                Console.WriteLine($"Вам нужно похудеть, ИМТ-{i:N2}");
                ideal = weight - max;
                Console.WriteLine($"Вам нужно похудеть на {ideal:N2} кг для нормализации веса");
                Pause();
            }
            Console.WriteLine("Для возврата к выбору задания нажмите любую кнопку...");
            Pause();
        }
        #endregion
        #region 6 Задание
        // Автор: Эрнестас Рахмангуловас
        //6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
        //«Хорошим» называется число, которое делится на сумму своих цифр.
        //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

        static void Task6()
        {
            Console.Clear();
            Console.WriteLine(" 6 Задание");
            Console.WriteLine("Программа подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.");
            Console.WriteLine(" Идет подсчет, ожидайте...");
            int number, goodCount = 0, sum;
            DateTime time = DateTime.Now;

            for (int i = 1; i <= 1000000000; i++)
            {
                sum = 0;
                number = i;
                while (number != 0)
                {
                    sum = sum + number % 10; // Оператор остатка % = a - (a / b) * b;
                    number = number / 10;
                }
                if (i % sum == 0)
                {
                    goodCount++;
                }
            }


            Console.WriteLine("Количество «хороших» чисел: " + goodCount);
            Console.WriteLine("Времени выполнения программы " + (DateTime.Now - time));
            Console.WriteLine("Для возврата к выбору задания нажмите любую кнопку...");
            Pause();

        }
        #endregion
        #region 7 Задание
        // Автор: Эрнестас Рахмангуловас
        //7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        //   б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

        static void Task7()
        {
            Console.Clear();
            Console.WriteLine(" 7 Задание");
            Console.WriteLine(" Программа выыодит числа на экран от А до Б.");
            Console.WriteLine(" Введите А:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Введите Б:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Числа от А до Б: ");
            AToB(a, b);
            Console.WriteLine();
            Sum(a, b);
            Console.Write("Cуммa чисел от А до Б= ");
            Console.WriteLine(Sum(a, b));

            Console.WriteLine();

            Console.WriteLine("Для возврата к выбору задания нажмите любую кнопку...");
            Pause();
        }
        static void AToB(int a, int b)
        {
            Console.Write("{0,1} ", a);
            if (a < b)
            {
                AToB(a + 1, b);
            }
        }

        static int Sum(int a, int b)
        {
            if (a == b)
            {
                return a;
            }

            else
            {
                return a + Sum(a + 1, b);

            }

        }
        /*static void Sum(int a, int b)
	    {
            int sum=0;
		    while (a <= b)
            {
                sum = sum + a;
                a++;
                
            }
            Console.WriteLine("Cуммa чисел от А до Б=" + sum);
         }
        */

        #endregion
        static void Main(string[] args)
        {

        start:
            Console.Clear();
            Console.WriteLine("Для выбора номера задания нажмите соответствующую кнопку:");
            Console.WriteLine(" 1 Задание: кнопка 1" + "\n 2 Задание: кнопка 2" + "\n 3 Задание: кнопка 3" + "\n 4 Задание: кнопка 4" + "\n 5 Задание: кнопка 5" + "\n 6 Задание: кнопка 6" + "\n 7 Задание: кнопка 7");
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

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Task6();
                    goto start;

                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    Task7();
                    goto start;
            }
        }
    }
}