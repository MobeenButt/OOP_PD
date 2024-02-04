using System;
using System.Collections.Generic;

namespace Book
{
    internal class BookInfo
    {
        public string title;
        public string author;
        public int publicationyear;
        public double price;
        public int stock;

        public BookInfo()
        {

        }
        public BookInfo(string title, string author, int publicationyear, double price, int stock)
        {
            this.title = title;
            this.author = author;
            this.publicationyear = publicationyear;
            this.price = price;
            this.stock = stock;
        }
        public string getTitle()
        {
            return $"Title: {title}";
        }
        public string getAuthor()
        {
            return $"Author: {author}";
        }
        public string Year()
        {
            return $"Publication Year: {publicationyear}";
        }
        public string getPrice()
        {
            return $"Price: {price}";

        }
        public void SellCopies(int numberOfCopies)
        {
            if (stock >= numberOfCopies)
            {
                stock = stock - numberOfCopies;
                Console.WriteLine($"{numberOfCopies} Copies Sold Successfully...");
            }
            else
            {
                Console.WriteLine($"Error: Insufficient Copies in Stock. Available: {stock}");
            }
        }
        public void Restock(int additionalCopies)
        {
            stock = stock + additionalCopies;
            Console.WriteLine($"{additionalCopies} Copies Restocked Successfully..");
        }
        public string BookDetails()
        {
            return $"Book Title:{getTitle()},Book Author:{getAuthor()},Publication Year:{Year()},Price:{getPrice()}, Quantity in Stock: {stock}";
        }
     
    }
}
