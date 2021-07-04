using System;
//найти количество повторяющихся слов в 2-ух строчках используя только string
namespace ConsoleApp2
    
{class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст 1: ");
            string str = Console.ReadLine();
            Console.WriteLine("Введите текст 2: ");
            string str2 = Console.ReadLine();
            bool f = false;

            int n = 0;
            string[] mas = str.Split(" ");
            string[] mas2 = str2.Split(" ");

            foreach (string s in mas)
            {
              for (int i = 0; i < mas2.Length; i++)
                {
                    if (s == mas2[i])
                    {
                        Console.WriteLine("Повторяющиеся слова: {0}", mas2[i]);
                        f = true;
                        break;
                    }
                    
                    
                }  
                
                   
                
            }
            if (!f) Console.WriteLine("Повторяющихся слов нет ");
            Console.ReadKey();
        }
    }
}
