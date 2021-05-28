using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    
    // Эрнестас Рахмангуловас
   

    
    
    class Program
    {
        #region 1 Задание
    /*1.
        а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
        б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
        в) Добавить диалог с использованием switch демонстрирующий работу класса.
    */
        class Complex
        {

            double im;
            double re;


            public Complex()
            {
                im = 0;
                re = 0;
            }

            public Complex(double im, double re)
            {

                this.im = im;
                this.re = re;
            }
            public Complex Plus(Complex x2)
            {
                Complex x3 = new Complex();
                x3.im = x2.im + im;
                x3.re = x2.re + re;
                return x3;
            }
            public Complex Minus(Complex x2)
            {
                Complex x3 = new Complex();
                x3.im = x2.im - im;
                x3.re = x2.re - re;
                return x3;
            }
            public Complex Multi(Complex x2)
            {
                Complex x3 = new Complex();
                x3.im = x2.im * im;
                x3.re = x2.re * re;
                return x3;
            }
        
            public double Im
            {
                get { return im; }
                set
                {
                    if (value >= 0) im = value;
                }
            }

            public string ToString1()
            {
                return re + "+" + im + "i";
            }
        }
        static void Task1()
        {
            Console.WriteLine();
                    Console.Clear();
                    Complex complex1;
                    complex1 = new Complex(5, 5);
                    Complex complex2 = new Complex(10, 10);
                    Complex result;



            Console.WriteLine("Для выбора действия соответствующую кнопку:");
            Console.WriteLine(" 1 Сложение: кнопка 1" + "\n 2 Вычитание: кнопка 2" + "\n 3 Произведение: кнопка 3");
            ConsoleKeyInfo TaskNumber = Console.ReadKey();
            switch (TaskNumber.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    Console.WriteLine(" Сложение: ");
                    result = complex1.Plus(complex2);
                    Console.WriteLine(result.ToString1());
                    Console.ReadKey();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.WriteLine(" Вычитание: ");
                        result = complex1.Minus(complex2);
                        Console.WriteLine(result.ToString1());
                        Console.ReadKey();
                        break;

               case ConsoleKey.D3:
               case ConsoleKey.NumPad3:
                        Console.Clear();
                        Console.WriteLine(" Произведение: ");
                        result = complex1.Multi(complex2);
                        Console.WriteLine(result.ToString1());
                        Console.ReadKey();
                        break;

            }

        }
         #endregion 
        #region 2 Задание
        /*2.
            а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
            Требуется подсчитать сумму всех нечётных положительных чисел. 
            Сами числа и сумму вывести на экран, используя tryParse.
        */

        static int GetInt() 
        {
            while (true)
            if (!int.TryParse(Console.ReadLine(), out int x))
                Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
            else return x;
        }
        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Вас приветствует программа подсчета нечетных положительных чисел");
            Console.WriteLine("Вводите числа по одному, для завершения введите 0: ");

                int sum = 0;
                while (true)
                {
                    int number = GetInt();
                    if (number == 0)
                    {
                        break;
                    }
                    else if (number > 0 && number % 2 == 1)
                    {
                        sum = sum + number;
                    }
                }
            Console.WriteLine("Сумма нечетных положительных чисел= " + sum);
            Console.ReadKey();
            
        }
        #endregion
        #region 3 Задание
        
        static int GetInt2()
        {       
            while (true)
            if (!int.TryParse(Console.ReadLine(), out int x)) 
                { 
                 Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
                }
            else return x;
        }

        
        
        class Fraction
        {
            int numerator;
            int denominator;

        
            public int Denominator
            {
                get { return denominator; }
                set
                {
                    if (value == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
                    else
                        denominator = value;
                }
            }

            
            public Fraction()
            {
                numerator = 1;
                denominator = 1;
            }

            
            /// numerator - Числитель
            /// <denominator - Знаменатель
           
            public Fraction(int numerator, int denominator)
            {
                this.numerator = numerator;
                this.Denominator = denominator;
            }

            
            public Fraction Plus(Fraction x)
            {
                Fraction y = new Fraction();
                y.denominator = Fraction.NOZ(x.denominator, this.denominator);
                y.numerator = (x.numerator * (y.denominator / x.denominator)) + (this.numerator * (y.denominator / this.denominator));
                return y;
            }

            
            public Fraction Minus(Fraction x)
            {
                Fraction y = new Fraction();
                y.denominator = Fraction.NOZ(x.denominator, this.denominator);
                y.numerator = (this.numerator * (y.denominator / this.denominator)) - (x.numerator * (y.denominator / x.denominator));
                return y;
            }

            
            public Fraction Multi(Fraction x)
            {
                Fraction y = new Fraction();
                y.numerator = x.numerator * numerator;
                y.denominator = x.denominator * denominator;
                return y;
            }

            
            public Fraction Division(Fraction x)
            {
                Fraction y = new Fraction();
                y.numerator = x.denominator * numerator;
                y.denominator = x.numerator * denominator;
                return y;
            }

            
            public string ToString()
            {
                return "(" + numerator + "/" + denominator + ")";
            }

            
            static int NOD(int a, int b)
            {
                while (a != b) 
                { 
                    if (a == 0)
                        break;
                    if (a > b) a = a - b; else b = b - a;
                }
                return a;
            }

            
            static int NOZ(int a, int b)
            {
                int noz;
                int newnoz;
                int multiplier = 2;
                if (a > b)
                {
                    noz = a;
                    if (noz % b == 0)
                        return noz;
                }
                else
                {
                    noz = b;
                    if (noz % a == 0)
                        return noz;
                }
                while (true)
                {
                    newnoz = noz * multiplier;
                    if (newnoz % a == 0 && newnoz % b == 0)
                        return newnoz;
                    multiplier++;
                }
            }

            
            public void Simplification()
            {
                int num = this.numerator;
                int denom = this.denominator;
                int nod = Fraction.NOD(Math.Abs(num), Math.Abs(denom));
                while (nod != 1 && nod != 0)
                {
                    this.numerator = num / nod;
                    this.denominator = denom / nod;
                    num = this.numerator;
                    denom = this.denominator;
                    nod = Fraction.NOD(Math.Abs(num), Math.Abs(denom));
                }
            }
        }
        static Fraction Init(int numerator, int denumerator)
        {
            bool checkException;
            Fraction fraction = null;
            do
            {
                checkException = false;
                try
                {
                    fraction = new Fraction(numerator, denumerator);
                }
                catch (ArgumentException ex)
                {
                    checkException = true;
                    Console.WriteLine("Ошибка: " + ex.Message);
                    Console.Write("Повторно введите знаменатель дроби: ");
                    denumerator = GetInt();
                }
            } while (checkException);
            
            return fraction;
        }
        static void Task3()
        {
            Console.Clear();
            Console.WriteLine("Вас приветствует программа работы с дробями!");
            Console.Write("Введите числитель первой дроби: ");
            int n1 = GetInt2();
            Console.Write("Введите знаминатель первой дроби: ");
            int d1 = GetInt2();
            Console.Write("Введите числитель второй дроби: ");
            int n2 = GetInt2();
            Console.Write("Введите знаминатель второй дроби: ");
            int d2 = GetInt2();
            Fraction fraction1 = Init(n1, d1);
            Fraction fraction2= Init(n2, d2);

            Console.WriteLine();
            Fraction result = fraction1.Plus(fraction2);
            result.Simplification();
            Console.WriteLine("Результом операции сложения чисел: " + fraction1.ToString() + " и " + fraction2.ToString() + " является "
                + result.ToString());
            result = fraction1.Minus(fraction2);
            result.Simplification();
            Console.WriteLine("Результом операции вычитания чисел: " + fraction1.ToString() + " и " + fraction2.ToString() + " является "
               + result.ToString());
            result = fraction1.Multi(fraction2);
            result.Simplification();
            Console.WriteLine("Результом операции умножения чисел: " + fraction1.ToString() + " и " + fraction2.ToString() + " является "
               + result.ToString());
            result = fraction1.Division(fraction2);
            result.Simplification();
            Console.WriteLine("Результом операции деления чисел: " + fraction1.ToString() + " и " + fraction2.ToString() + " является "
               + result.ToString());

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
