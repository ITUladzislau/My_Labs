using System;
using System.Collections.Generic;
//Создать класс «домашняя библиотека».
//Предусмотреть возможность работы с произвольным числом книг,
//поиска книги по какому-либо признаку (например, по автору или по году издания),
//добавления книг в библиотеку, удаления книг из нее, сортировки книг по разным полям.

namespace Laba2ValiaPart2
{
    class Lib
    {
        List<Book> lib = new List<Book>();
        
        public void Add(Book b)
        {
            lib.Add(b);
        }
        public void SearchAuth(string a)
        {
            foreach(Book b in lib)
            {
                if(b.auth == a)Console.WriteLine($"Книга автора {b.auth} :{b.name}");
            }
        }
        public void DeleteBook(string name)
        {
            for(int i = 0;i<lib.Count;i++)
            {
                if (lib[i].name == name)
                {
                    Console.WriteLine($"Книга {lib[i].name} удалена");
                    lib.Remove(lib[i]);  
                }
            } 
        }

    }

    class Book
    {
        public string name;
        public int year;
        public string auth;
        public Book(string name, int year, string auth)
        {
            this.name = name;
            this.year = year;
            this.auth = auth;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lib lib1 = new Lib();
            Book b1 = new Book("война и мир", 1865, "Толстой");
            lib1.Add(b1);
            lib1.SearchAuth("Толстой");
            lib1.DeleteBook("война и мир");
        }
    }
}
