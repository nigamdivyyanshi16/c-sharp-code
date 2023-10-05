// See https://aka.ms/new-console-template for more information
using System;

class Author
{
    private string name;
    private string email;
    private char gender;

    public Author(string name, string email, char gender)
    {
        this.name = name;
        this.email = email;
        this.gender = gender;
    }

    public string GetName()
    {
        return name;
    }

    public string GetEmail()
    {
        return email;
    }

    public char GetGender()
    {
        return gender;
    }

    public override string ToString()
    {
        return $"Author[name={name},email={email},gender={gender}]";
    }
}

class Book
{
    private string name;
    private Author author;
    private double price;
    private int qty;

    public Book(string name, Author author, double price)
    {
        this.name = name;
        this.author = author;
        this.price = price;
        this.qty = 0; // Default qty value
    }

    public Book(string name, Author author, double price, int qty)
    {
        this.name = name;
        this.author = author;
        this.price = price;
        this.qty = qty;
    }

    public string GetName()
    {
        return name;
    }

    public Author GetAuthor()
    {
        return author;
    }

    public double GetPrice()
    {
        return price;
    }

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public int GetQty()
    {
        return qty;
    }

    public void SetQty(int qty)
    {
        this.qty = qty;
    }

    public override string ToString()
    {
        return $"Book[name={name},{author},price={price},qty={qty}]";
    }

    public string GetAuthorName()
    {
        return author.GetName();
    }

    public string GetAuthorEmail()
    {
        return author.GetEmail();
    }

    public char GetAuthorGender()
    {
        return author.GetGender();
    }
}

class TestBook
{
    static void Main(string[] args)
    {
        // Construct an author instance
        Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm');
        Console.WriteLine(ahTeck);  // Author's toString()

        Book dummyBook = new Book("Java for dummy", ahTeck, 19.95, 99);  // Test Book's Constructor
        Console.WriteLine(dummyBook);  // Test Book's toString()

        // Test Getters and Setters
        dummyBook.SetPrice(29.95);
        dummyBook.SetQty(28);
        Console.WriteLine("name is: " + dummyBook.GetName());
        Console.WriteLine("price is: " + dummyBook.GetPrice());
        Console.WriteLine("qty is: " + dummyBook.GetQty());
        Console.WriteLine("Author is: " + dummyBook.GetAuthor());  // Author's toString()
        Console.WriteLine("Author's name is: " + dummyBook.GetAuthorName());
        Console.WriteLine("Author's email is: " + dummyBook.GetAuthorEmail());

        // Use an anonymous instance of Author to construct a Book instance
        Book anotherBook = new Book("more Java",
            new Author("Paul Tan", "paul@somewhere.com", 'm'), 29.95);
        Console.WriteLine(anotherBook);  // toString()

        // Print name and email of author from a Book instance
        Console.WriteLine("Author's name from Book: " + dummyBook.GetAuthorName());
        Console.WriteLine("Author's email from Book: " + dummyBook.GetAuthorEmail());
    }
}

