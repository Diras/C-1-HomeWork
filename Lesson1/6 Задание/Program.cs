using System;


//Автор: Ernestas Rachmangulovas


namespace _6_Задание
{
    class Program
    {
        static void Center(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }

        static void Pause();   
        {
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
        }
    }
}
