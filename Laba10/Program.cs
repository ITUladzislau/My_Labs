using System;
using System.Collections.Generic;
//Написать функцию, которая по двум данным линейным спискам формирует новый список, состоящий из элементов, одновременно входящих в оба данных списка.
namespace Laba10Valia
{
    class Program
    {
        public static List<int> GetList(List<int> s1 , List<int>s2 )
        {
            List<int> s3 = new List<int>();
            foreach (int a in s1)
            {
                if (s2.Contains(a))s3.Add(a); 
            }
            return s3;
        }

        static void Main(string[] args)
        {
            List<int> s1 = new List<int>();
            List<int> s2 = new List<int>();
            s1.Add(1234);
            s1.Add(666);
            s1.Add(988);
            s1.Add(34);

            s2.Add(986);
            s2.Add(666);
            s2.Add(342);
            s2.Add(34);

            foreach (int a in GetList(s1, s2))
            {
                Console.WriteLine(a);
            }
        }
    }
}
