using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BOOK LOTR = new BOOK();
            LOTR.SetTitlez("idiot");
            LOTR.SetPagesz(666);
            LOTR.SetCategorz("Balalajka");
            LOTR.SetAuthorz("Janči");
            LOTR.SetReleaseDatez(564156);
            LOTR.Hiolp();
        }
    }
    class BOOK
    {
        string M = " ";
        string title;
        int pages;
        string category;
        string author;
        int releaseDate;
        public void SetTitlez(string a)
        {
            title = a;                        
        }
        public void SetPagesz(int b)
        {
            pages = b;
        }
        public void SetCategorz(string c)
        {
            category = c;
        }
        public void SetAuthorz(string d)
        {
            author = d;
        }
        public void SetReleaseDatez(int e)
        {
            releaseDate = e;
        }
        public void Hiolp()
        {
            Console.WriteLine(title + M + pages + M + category + M + author + M + releaseDate);
        }
    }
}