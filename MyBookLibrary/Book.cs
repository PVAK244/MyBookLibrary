using System;

namespace MyBookLibrary
{
    public class Book
    {
        private int id;
        private string name;
        private string publisher;
        private double price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public double Price { get => price; set => price = value; }

        public Book(int id, string name, string publisher, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Publisher = publisher;
            this.Price = price;
        }

        public Book()
        {
        }

        override
        public String ToString()
        {
            return $"ID: {id}, Name: {Name}, Publisher: {publisher}, Price: {price}";
        }
    }
}
