using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Lesson5
{
    class Program
    {
        #region  Task 1
            // Автор: Эрнестас Рахмангуловас
            /*1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
             * содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
                а) без использования регулярных выражений;
                б) **с использованием регулярных выражений.
            */
            static void Task1()
            {
                Console.Clear();
                Console.WriteLine("1 Задание");
                bool check=true;
                do
                {
                    Console.WriteLine("Введите логин от 2 до 10 символов:...");
                    string login = Console.ReadLine();
                    login.ToCharArray();
                    for (int i = 0; i < login.Length; i++)
                    {
                        if (char.IsPunctuation(login[i]) || char.IsSeparator(login[i]) || char.IsSymbol(login[i]))
                            {
                            Console.WriteLine("Логин не может включать знаки препинания, пробелы и символы! ");
                            check = true;
                            }
                                       
                    }
                    for (int i = 0; i < login.Length; i++)
                    {
                        int num = login[i];
                        if (num>=65 && num<= 90 || num>= 97 && num<= 122)
                        check = false;
                        else 
                        {
                            check = true;
                            Console.WriteLine("Логин может содержать только латинские буквы! ");
                        }    
                    }
                    if (char.IsDigit(login[0]))
                    {
                        Console.WriteLine("Первый символ н может быть цифрой!");
                        check = true;
                    }
                    
                    else if( login.Length <2 || login.Length > 10)
                    {
                        Console.WriteLine("Логин не может быть менее 2 и более 10 символов! ");
                        check = true;
                    }
                                    
                    
                }
                while (check==true);
                Console.WriteLine("Логин введен верно! ");
                Console.ReadKey();
                do
                {
                    Console.WriteLine("Введите логин от 2 до 10 символов:...");
                    Regex login1 = new
                    Regex(@"[A-Za-z]{1}[A-Za-z0-9]{2,10}");
                    if (login1.IsMatch(Console.ReadLine()))
                    break;
                     
                    Console.ReadKey();
                }
                while (true);
                Console.WriteLine("Логин введен верно! ");
                Console.ReadKey();
            }


        #endregion
        #region  Task 2
        // Автор: Эрнестас Рахмангуловас
        /*2.2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            а) Вывести только те слова сообщения, которые содержат не более n букв.
            б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            в) Найти самое длинное слово сообщения.
            г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст,
                в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
                Здесь требуется использовать класс Dictionary.
        */  
            static class Message
            { 
                
                static public void GetWordsByLength(string text, int length)
                {
                    string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
                
                    foreach (string word in words)
                    {
                        if (word == "")
                            continue;
                        if (word.Length <= length)
                            Console.Write(word + " ");
                    }
                }
                static public void DeleteWordByEndChar(string text, char ch)
                {
                    string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
                    foreach (string word in words)
                    {
                        if (word == "")
                            continue;
                        if (word[word.Length - 1] == ch)
                        {
                            Console.Write(word + " ");
                            text.Replace(word, "");
                        }
                    }
                    
                }
                static public string FindLongestWord(string text)
                {
                    string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
                    string maxWord = words[0];
                    int max = words[0].Length;
            
                    foreach (string word in words)
                    {
                        if (word.Length > max)
                        {
                            max = word.Length;
                            maxWord = word;
                        }
                    }
                    return maxWord;
                }
                static public StringBuilder WriteLongestWordstring(string text)
                {
                    string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
                    StringBuilder result = new StringBuilder();
                    int max = Message.FindLongestWord(text).Length;
                    foreach (string word in words)
                    {
                        if (word.Length == max)
                        {
                            result.Append(word.ToLower() + " ");
                        }
                    }
                    return result;
                }
            }
                static void Task2()
                {
                    int n;
                    Console.Clear();
                    Console.WriteLine("2 Задание");
                    Console.WriteLine("Введите тескт для обработки:...");
                    String text = Console.ReadLine();
                    Console.WriteLine("Выведем слова текста, которые содержат не более N букв, введите количество букв: ");
                    n = int.Parse(Console.ReadLine());
                    Message.GetWordsByLength(text, n);
                    Console.Write ("\nУдалим из текста слова, заканчивающиеся на 'букву', введите букву: ");
                    char del;
                    del = char.Parse(Console.ReadLine());
                    Message.DeleteWordByEndChar(text, del);
                    Console.WriteLine("\nСамое длинное слово в тексте: " + Message.FindLongestWord(text));
                    Console.WriteLine("\nСформированная строка StringBuilder из самых длинных слов сообщения: \n" + Message.WriteLongestWordstring(text));
                    Console.ReadKey();



                }
            
        #endregion
        
        
        static void Main(string[] args)
        {

            start:
            Console.Clear();
            Console.WriteLine("Для выбора номера задания нажмите соответствующую кнопку:");
            Console.WriteLine(" 1 Задание: кнопка 1" + "\n 2 Задание: кнопка 2");
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

                    

               

            }
        }
    }
}
