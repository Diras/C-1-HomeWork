using System;

//Автор: Ernestas Rachmangulovas


namespace _2_Задание
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
            // где m — масса тела в килограммах, h — рост в метрах.

            Console.WriteLine("Вас приветствует програпмма по расчету индекса массы тела(ИМТ), прошу ответить на следующие вопросы:");
            
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
        }
    }
}
