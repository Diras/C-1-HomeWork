using System;

namespace Lesson1
{
    //Автор: Ernestas Rachmangulovas
    class Program
    {

        static double distance()
          {
            return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
          }

        

        static void Main(string[] args)
        {
            
            #region 1 Задание
            /* 
             1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
             В результате вся информация выводится в одну строчку:
                а) используя склеивание;
                б) используя форматированный вывод;
                в) используя вывод со знаком $.
            */

            Console.WriteLine("Вас приветствует програпмма Анкета, прошу ответить на следующие вопросы");
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите фамилию:");
            string surname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите ваш возраст в годах:");
            string age = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите ваш рост в сантиметрах:");
            string height = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите ваш вес в килограммах:");
            string weight = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Имя: " + name + ", фамилия: " + surname + ", возраст: " + age + "г.," + " рост: " + height + " см.," + " вес: " + weight + " кг.");
            Console.WriteLine("Имя: {0}, фамилия: {1}, возраст: {2}г., рост: {3} см., вес: {4} кг.", name, surname, age, height, weight);
            Console.WriteLine($"Имя: {name}, фамилия: {surname}, возраст: {age}г., рост: {height} см., вес: {weight} кг.");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region 2 Задание
            // 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
            // где m — масса тела в килограммах, h — рост в метрах.

            Console.WriteLine("Вас приветствует програпмма по расчету индекса массы тела(ИМТ), прошу ответить на следующие вопросы");
            
            Console.WriteLine("Введите ваш вес в килограммах:");
            string a = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите ваш рост в сантиметрах:");
            string b = Console.ReadLine();
            Console.Clear();
            double m, h, i;
            m = Convert.ToDouble(a);
            h = Convert.ToDouble(b);
            Console.Clear();
            h = h / 100;
            i = m / (h * h);
            Console.WriteLine("Ваш ИМТ = " + i);
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region 3 Задание

            /*
            а) Написать программу, которая подсчитывает расстояние между точками с координатами:
            x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
            Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);

            б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            */
            // a)
            Console.WriteLine("Вас приветствует програпмма по расчету расстояния между точками координат, прошу ввести коордтнаты X,Y первой точки и X,Y второй точки");
            double x1, x2, y1, y2, r;
            Console.WriteLine("Введите координаты первой точки:");
            Console.Write("X =");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Y =");
            y1 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите координаты второй точки:");
            Console.Write("X =");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Y =");
            y2 = double.Parse(Console.ReadLine());
            Console.Clear();
            r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            Console.WriteLine($"Расстояния между точками координат = {r:F2}");
            Console.ReadLine();
            Console.Clear();
            
            // b))

            Console.WriteLine("Вас приветствует програпмма по расчету расстояния между точками координат, прошу ввести коордтнаты X,Y первой точки и X,Y второй точки");
            
            Console.WriteLine("Введите координаты первой точки:");
            Console.Write("X =");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Y =");
            y1 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите координаты второй точки:");
            Console.Write("X =");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Y =");
            y2 = double.Parse(Console.ReadLine());
            Console.Clear();
                        
            Console.WriteLine($"Расстояния между точками координат = {distance:F2}");
            Console.ReadLine();
            Console.Clear();
            
            #endregion

            #region

            /*
            4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            а) с использованием третьей переменной;
            б) *без использования третьей переменной.
            */




            #endregion
        }
            


    }
}
