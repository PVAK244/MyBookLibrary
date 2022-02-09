using System;
using System.Collections.Generic;

namespace MyBookLibrary
{
    public class ListBook
    {
        private List<Book> books;

        public ListBook()
        {
            books = new List<Book>();
        }

        public Book existID(int id)
        {
            foreach(Book book in books)
            {
                if(book.Id == id) return book;
            }
            return null;
        }

        public void AddBook(int id, string name, string publisher, double price)
        {
            if (existID(id) == null)
            {
                books.Add(new Book(id, name, publisher, price));
                Console.WriteLine("Status of the action: sucess");
            }
            else Console.WriteLine("Status of the action: failure\nId exist");
        }

        public void Update(int id, string name, string publisher, double price)
        {
            Book b = new Book(id, name, publisher, price);
            foreach(Book book in books)
            {
                book.Name = name;
                book.Publisher = publisher;
                book.Price = price;
            }
            Console.WriteLine("Status of the action: sucess");
        }

        public void Delete(int id)
        {
            Book book = existID(id);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine("Status of the action: sucess");
            }
            else Console.WriteLine("Status of the action: failure\nId do not exist");
        }


        public void PrintAll()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
