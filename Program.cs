using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>();
        {
            books.Add(new Book(1, "The Great Gatsby", "F. Scott Fitzgerald", 10.99));
            books.Add(new Book(2, "To Kill a Mockingbird", "Harper Lee", 8.99));
            books.Add(new Book(3, "1984", "George Orwell", 9.99));
            books.Add(new Book(4, "Pride and Prejudice", "Jane Austen", 7.99));
            books.Add(new Book(5, "The Catcher in the Rye", "J.D. Salinger", 6.99));
        }
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("=== List of Books ===");
        Console.ResetColor();
        Console.WriteLine("Books in the collection:");
        foreach (Book book in books)
        {
            book.Display();
            Console.WriteLine("-----------------------");
        }

        Console.WriteLine("Enter the title of the book to search:");
        string searchTitle = Console.ReadLine();
        Book foundbook = books.Find(b => b.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase));
        if (foundbook != null)
        {
            Console.WriteLine("Book found:");
            foundbook.Display();
        }
        else
        {
            Console.WriteLine("Book not found.");
        }

        Console.WriteLine("Enter the title of the book to remove:");
        string removeTitle = Console.ReadLine();
        Book removeBook = books.Find(b => b.Title.Equals(removeTitle, StringComparison.OrdinalIgnoreCase));
        if (removeBook != null)
        {
            books.Remove(removeBook);
            Console.WriteLine("Book removed successfully.");
            Console.WriteLine("-----------------------");
            Console.WriteLine("The book removed is: " + removeBook.Title);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Books in the collection after removal:");
            foreach (Book book in books)
            {
                book.Display();
                Console.WriteLine("-----------------------");
            }
        }
        else
        {
            Console.WriteLine("Book not found. Cannot remove.");
        }

        Console.WriteLine("Tri books by price:");
        List<Book> sortedBooks = books.OrderBy(b => b.Price).ToList();
        foreach (Book book in sortedBooks)
        {
            book.Display();
            Console.WriteLine("-----------------------");
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("=== Dictionary ===");
        Console.ResetColor();

        Dictionary<int, Book> bookDictionary = new Dictionary<int, Book>();
        foreach (Book book in books)
        {
            bookDictionary.Add(book.Id, book);
        }
        Console.WriteLine("Enter the id of the book to search:");
        int searchId = int.Parse(Console.ReadLine());
        if (bookDictionary.TryGetValue(searchId, out Book foundBookById))
        {
            Console.WriteLine("Book found");
            foundBookById.Display();
        }
        else
        {
            Console.WriteLine("Book not found.");
        }

        Console.WriteLine("Parcours Dictionary:");
        foreach (KeyValuePair<int, Book> item in bookDictionary)
        {
            Console.WriteLine("Key: " + item.Key);
            item.Value.Display();
            Console.WriteLine("-----------------------");
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Utilsation of Stack:");
        Console.ResetColor();
        Stack<Book> bookStack = new Stack<Book>();
        foreach (Book book in books)
        {
            bookStack.Push(book);
        }
        Console.WriteLine("Books in the stack:");
        while (bookStack.Count > 0)
        {
            Book book = bookStack.Pop();
            book.Display();
            Console.WriteLine("-----------------------");
        }

        foreach (Book book in books)
        {
            bookStack.Push(book);
        }

        Console.WriteLine("Last book added to the stack");
        if (bookStack.Count > 0)
        {
            Book lastBook = bookStack.Peek();
            lastBook.Display();
        }
        else
        {
            Console.WriteLine("Stack is empty.");
        }
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("Utilisation de Queue:");
        Console.ResetColor();
        Queue<Book> bookQueue = new Queue<Book>();

        bookQueue.Enqueue(books[0]);
        bookQueue.Enqueue(books[1]);
        bookQueue.Enqueue(books[2]);

        System.Console.WriteLine("Dequeue:");
        while (bookQueue.Count > 0)
        {
            Book book = bookQueue.Dequeue();
            book.Display();
            System.Console.WriteLine("-----------------------");
        }
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("Using LINQ");
        Console.ResetColor();

        System.Console.WriteLine("Books with price greater than 10:");
        var expensiveBooks = books.Where(b => b.Price > 10);
        foreach (Book book in expensiveBooks)
        {
            book.Display();
            System.Console.WriteLine("-----------------------");
        }

        System.Console.WriteLine("Enter the minimum price of a book to search:");
        double minPrice = double.Parse(Console.ReadLine());
        var booksAboveMinPrice = books.Where(b => b.Price > minPrice);
        System.Console.WriteLine("Books with price greater than " + minPrice + ":");
        foreach (Book book in booksAboveMinPrice)
        {
            book.Display();
            System.Console.WriteLine("-----------------------");    
        }

        System.Console.WriteLine("Books sorted by title:");
        var sortedByTitile=books.OrderBy(b=>b.Title);
        foreach( Book book in sortedByTitile)
        {
            book.Display();
            System.Console.WriteLine("-----------------------");
        }

        System.Console.WriteLine("Average price of books:");
        double averagePrice=books.Average(b=>b.Price);
        System.Console.WriteLine("Average price: "+averagePrice);

        System.Console.WriteLine("Counting all of Books:");
        int countBooks=books.Count();
        System.Console.WriteLine("Total number of books: "+countBooks);
    }
}