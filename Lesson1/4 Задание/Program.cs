using System;

//Автор: Ernestas Rachmangulovas


namespace _4_Задание
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            а) с использованием третьей переменной;
            б) *без использования третьей переменной.
            */


            // а)

           int a = 1;     
           int b = 2;     
           int t = a;  
           b = t;
           
            // b)

            int x = 10;
            int y = 20;
            x = y;


        
        }
    }
}
