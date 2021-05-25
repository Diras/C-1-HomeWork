using System;


//Автор: Ernestas Rachmangulovas


namespace _1_Задание
{
    class Program
    {
        static void Main(string[] args)
        {

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
            
        }
    }
}
