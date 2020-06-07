using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace OOP3
{
    class Book
    {
        string author = "???";
        string title = "???";
        string pages = "???";
        bool collectionEdition = false;
        string collection = "";
        public Book()
        {
            collection = "???";
            Vivod();
        }
        public Book(string author)
        {
            this.author = author;
            collection = "???";
            Vivod();
        }
        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
            collection = "???";
            Vivod();
        }
        public Book(string author, string title, string pages)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            collection = "???";
            Vivod();
        }
        public Book(string author, string title, string pages, bool collectionEdition)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.collectionEdition = collectionEdition;
            Vivod();
        }
        public Book(string author, string title, bool collectionEdition)
        {
            this.author = author;
            this.title = title;
            this.collectionEdition = collectionEdition;
            Vivod();
        }
        public Book(string author,bool collectionEdition)
        {
            this.author = author;
            this.collectionEdition = collectionEdition;
            Vivod();
        }
        public Book(bool collectionEdition)
        {
            this.collectionEdition = collectionEdition;
            Vivod();
        }

        public void Vivod()
        {
            Console.WriteLine("Автор: " + author);
            Console.WriteLine("Название: " + title);
            Console.WriteLine("Страниц: " + pages);
            if (collection=="") if (collectionEdition == true) Console.WriteLine("Издание: колекционное");
            else Console.WriteLine("Издание: не колекционное");
            else Console.WriteLine("издание: ???");
            Console.WriteLine("----------------------------");
        } 
    }
        class Program
        {
            static void Main(string[] args)
            {
                Book book1 = new Book("А. Пушкин");
                Book book2 = new Book("С. Есенин","Анна Снегина","150");
                Book book3 = new Book("С. Есенин", "Анна Снегина");
                Book book4 = new Book("А. Пушкин", "Метель", "100", true);
                Book book5 = new Book("Л. Толстой", "Война и мир", false);
                Book book6 = new Book("С. Есенин", true);
                Book book7 = new Book(false);
                Book book8 = new Book();

            Console.ReadKey();
            }
        }
    
}