// See https://aka.ms/new-console-template for more information
using System;

class Author
{
    private string name;
    private string email;

    public Author(string name, string email)
    {
        this.name = name;
        this.email = email;
    }

    public string GetName()
    {
        return name;
    }

    public string GetEmail()
    {
        return email;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public override string ToString()
    {
        return $"Author[name={name},email={email}]";
    }
}

class Book
{
    private string isbn;
    private string name;
    private Author author;
    private double price;
    private int qty;

    public Book(string isbn, string name, Author author, double price, int qty)
    {
        this.isbn = isbn;
        this.name = name;
        this.author = author;
        this.price = price;
        this.qty = qty;
    }

    public string GetIsbn()
    {
        return isbn;
    }

    public string GetName()
    {
        return name;
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

    public Author GetAuthor()
    {
        return author;
    }

    public string GetAuthorName()
    {
        return author.GetName();
    }

    public override string ToString()
    {
        return $"Book[isbn={isbn},name={name},{author},price={price},qty={qty}]";
    }
}

class TestMain
{
    static void Main(string[] args)
    {
        // Test Author class
        Author a1 = new Author("Tan Ah Teck", "ahteck@nowhere.com");
        Console.WriteLine(a1);

        a1.SetEmail("ahteck@somewhere.com");
        Console.WriteLine(a1);
        Console.WriteLine("name is: " + a1.GetName());
        Console.WriteLine("email is: " + a1.GetEmail());

        // Test Book class
        Book b1 = new Book("12345", "Java for dummies", a1, 8.8, 88);
        Console.WriteLine(b1);

        b1.SetPrice(9.9);
        b1.SetQty(99);
        Console.WriteLine(b1);
        Console.WriteLine("isbn is: " + b1.GetIsbn());
        Console.WriteLine("name is: " + b1.GetName());
        Console.WriteLine("price is: " + b1.GetPrice());
        Console.WriteLine("qty is: " + b1.GetQty());
        Console.WriteLine("author is: " + b1.GetAuthor());
        Console.WriteLine("author's name: " + b1.GetAuthorName());
        Console.WriteLine("author's name: " + b1.GetAuthor().GetName());
        Console.WriteLine("author's email: " + b1.GetAuthor().GetEmail());
    }
}
