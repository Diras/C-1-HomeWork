using System;


//Автор: Ernestas Rachmangulovas


namespace _5_Задание
{
    class Program
    {
        static void Center(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }


        static void Main(string[] args)
        {

            /*
            а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) Сделать задание, только вывод организовать в центре экрана.
            в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y). 
            */

            // а)
            string name = "Эрнест";
            string surname = "Рахмангулов";
            string city = "Вильнюс";
            Console.WriteLine("Имя: " + name + ". Фамилия: " + surname + ". Город проживания: " + city);
            Console.ReadLine();
            Console.Clear();


            //б)
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("Имя: " + name + ". Фамилия: " + surname + ". Город проживания: " + city);
            Console.ReadLine();
            Console.Clear();


            // в)

            Center("Имя: " + name + ". Фамилия: " + surname + ". Город проживания: " + city, 30, 15);
            Console.ReadLine();
        }
    }
}
