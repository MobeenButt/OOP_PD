
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BookInfo> bookList = new List<BookInfo>();

            // Creating books
            BookInfo book1 = new BookInfo
            {
                title = "Pride and Prejudice",
                author = "Jane Austen",
                publicationyear = 1813,
                price = 19.99,
                stock = 10
            };

            BookInfo book2 = new BookInfo
            {
                title = "Hamlet",
                author = "William Shakespeare",
                publicationyear = 1603,
                price = 15.50,
                stock = 15
            };

            BookInfo book3 = new BookInfo
            {
                title = "War and Peace",
                author = "Leo Tolstoy",
                publicationyear = 1869,
                price = 25.99,
                stock = 8
            };

            // Adding books to the list
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);

            //List<BookInfo> bookList = new List<BookInfo>();

            int choice;

            do
            {
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Books Information");
                Console.WriteLine("3. Author Details");
                Console.WriteLine("4. Sell Copies of a Book");
                Console.WriteLine("5. Restock Book");
                Console.WriteLine("6. Books Present");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        // Add Book
                        
                        AddBook(bookList);

                        break;

                    case 2:
                        // View All Books Information
                        
                        ViewAllBooks(bookList);
                        
                        break;

                    case 3:
                        // Get Author Details of a Specific Book
                        GetAuthorDetails(bookList);
                        break;

                    case 4:
                        // Sell Copies of a Specific Book
                        SellBookCopies(bookList);
                        break;

                    case 5:
                        // Restock a Specific Book
                        RestockBook(bookList);
                        break;

                    case 6:
                        // See the Count of Books Present
                        Console.WriteLine($"Number of Books: {bookList.Count}");
                        break;

                    case 7:
                        // Exit
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

            } while (choice != 7);
        }
        static void AddBook(List<BookInfo> bookList)
        {
            Console.Write("Enter Title of Book: ");
            string title = Console.ReadLine();
            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine();
            Console.Write("Enter Year of Publication: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter Price of Book: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter Quantity of Book: ");
            int quantity = int.Parse(Console.ReadLine());

            BookInfo newBook = new BookInfo(title, author, year, price, quantity);
            bookList.Add(newBook);
            Console.WriteLine("Book added successfully.");
        }
        static void ViewAllBooks(List<BookInfo> bookList)
        {
            Console.WriteLine("All Books Information:");
            foreach (var book in bookList)
            {
                Console.WriteLine(book.BookDetails());
            }
        }

        static void GetAuthorDetails(List<BookInfo> bookList)
        {
            Console.Write("Enter the Title of the book: ");
            string titleToSearch = Console.ReadLine();

            BookInfo foundBook = null;
            foreach (BookInfo book in bookList)
            {
                if (string.Equals(book.title, titleToSearch, StringComparison.OrdinalIgnoreCase))
                {
                    foundBook = book;
                    break;
                }
            }

            if (foundBook != null)
            {
                Console.WriteLine(foundBook.getAuthor());
            }
            else
            {
                Console.WriteLine($"Book with title \"titleToSearch\" not found.");
            }
        }

        static void SellBookCopies(List<BookInfo> bookList)
        {
            Console.Write("Enter the Title of the book: ");
            string titleToSearch = Console.ReadLine();
            BookInfo foundBook = null;

            foreach (BookInfo book in bookList)
            {
                if (string.Equals(book.title, titleToSearch, StringComparison.OrdinalIgnoreCase))
                {
                    foundBook = book;
                    break;
                }
            }

            if (foundBook != null)
            {
                Console.Write("Enter the number of copies to sell: ");
                if (int.TryParse(Console.ReadLine(), out int numberOfCopies))
                {
                    foundBook.SellCopies(numberOfCopies);
                }
                else
                {
                    Console.WriteLine("Invalid input for the number of copies.");
                }
            }
            else
            {
                Console.WriteLine($"Book with title \"titleToSearch\" not found.");
            }
        }

        static void RestockBook(List<BookInfo> bookList)
        {
            Console.Write("Enter the Title of the book: ");
            string titleToSearch = Console.ReadLine();
            BookInfo foundBook = null;

            foreach (BookInfo book in bookList)
            {
                if (string.Equals(book.title, titleToSearch, StringComparison.OrdinalIgnoreCase))
                {
                    foundBook = book;
                    break;
                }
            }

            if (foundBook != null)
            {
                Console.Write("Enter the number of copies to restock: ");
                if (int.TryParse(Console.ReadLine(), out int additionalCopies))
                {
                    foundBook.Restock(additionalCopies);
                }
                else
                {
                    Console.WriteLine("Invalid input for the number of copies.");
                }
            }
            else
            {
                Console.WriteLine($"Book with title \"titleToSearch\" not found.");
            }
        }
    }

}

