using System;
//Отсортируйте введенный через пробелы список фамилий по алфавиту и выведите его на экран.
namespace Laba4Valia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество слов");
            int n = Convert.ToInt32(Console.ReadLine());
            String[] s = new String[n];
            for(int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
            }
            Array.Sort(s);
            Console.WriteLine("Отсортированные фамилии:");
            foreach (string ss in s)
            {
                Console.WriteLine(ss);
            }
        }
    }
}
