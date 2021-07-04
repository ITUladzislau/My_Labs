using System;
//Создайте обобщенный класс CollectionType<T>.
//Определить в классе конструктор и другие необходимые методы
namespace Laba9
{
    class LSearch<T>
    {
        private T[] A;

        public LSearch()
        {
            A = null;
        }
        public LSearch(T[] _A)
        {

            A = (T[])_A.Clone();
        }
        public T[] Get()
        {
            return A;
        }
        public void Set(T[] _A)
        {
            A = (T[])_A.Clone();
        }
        public bool IsItem(T[] A, T key)
        {
            for (int i = 0; i < A.Length; i++)
                if (A[i].Equals(key)) 
                    return true;
            return false;
        }
        public bool IsItem(T key)
        {
            return IsItem(this.A, key);
        }
        public int GetNOccurences(T[] A, T key)
        {
            int k = 0;
            for (int i = 0; i < A.Length; i++)
                if (A[i].Equals(key))
                    k++;
            return k;
        }
        public int GetNOccurences(T key)
        {
            return GetNOccurences(this.A, key);
        }
        
        public void Print(string comment)
        {
            Console.WriteLine(comment);
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0}   ", A[i]);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] AI = { 5, 8, 9, -1, 4 };
            LSearch<int> L1 = new LSearch<int>(AI);
            if (L1.IsItem(8))
            {
                Console.WriteLine("Item 8 is in array AI");
            }
            else
            {
                Console.WriteLine("Item 8 is not in array AI");
            }
            char[] AC = { 'a', 'b', 'f', 'a', 'a', 'c', 'd', 'i', 'f' };
            LSearch<char> L2 = new LSearch<char>(AC);
            int n = L2.GetNOccurences('a');
            Console.WriteLine("n = {0}", n); 
            bool[] AB = { true, true, false, false, true, false, true, true };
            LSearch<bool> L3 = new LSearch<bool>();
            L3.Set(AB);
            L3.Print("Это True и False много раз");
            Console.ReadLine();
        }
    }
}

