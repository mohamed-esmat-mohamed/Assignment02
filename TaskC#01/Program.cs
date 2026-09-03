using System;

class Program
{
    static void Main()
    {
        // Q1

        int pages = 464;
        bool isAvailable = true;

        if (pages > 300 && isAvailable)
        {
            Console.WriteLine("You can borrow this book");
        }


        // Q2
        string title = "Refactoring";

        switch (title)
        {
            case "Clean Code":
                Console.WriteLine("Great choice!");
                break;
            case "Refactoring":
                Console.WriteLine("Nice pick!");
                break;
            default:
                Console.WriteLine("Never heard of it");
                break;
        }


        // Q3
        string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
        Console.WriteLine(sizeLabel);


        // Q4
        string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + books[i]);
        }


        //Q5
        int index = 0;
        while (index < books.Length)
        {
            Console.WriteLine(books[index]);
            index++;
        }


        // Q6
        int count = 0;
        do
        {
            Console.WriteLine("Checking book...");
            count++;
        } while (count < 3);


        // Q7
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }


        // Q8
        foreach (string book in books)
        {
            if (book == "Refactoring")
            {
                break;
            }
            Console.WriteLine(book);
        }


        // Q9
        foreach (string book in books)
        {
            if (book == "The Pragmatic Programmer")
            {
                continue;
            }
            Console.WriteLine(book);
        }


        // Q10
        PrintFirstBook(books);

        string[] emptyBooks = { };
        PrintFirstBook(emptyBooks);
    }


    static void PrintFirstBook(string[] booksArray)
    {
        if (booksArray.Length == 0)
        {
            return;
        }

        Console.WriteLine(booksArray[0]);
    }
}