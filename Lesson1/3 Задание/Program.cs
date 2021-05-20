using System;


//Автор: Ernestas Rachmangulovas


namespace _3_Задание
{
    class Program
    {
        static double distance(double x2, double x1, double y2, double y1)
            {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            }
        static void Main(string[] args)
        {
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
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
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

            Console.WriteLine($"Расстояния между точками координат = {distance(x2,x1,y2,y1):F2}");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
