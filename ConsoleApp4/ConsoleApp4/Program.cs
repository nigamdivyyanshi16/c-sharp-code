// See https://aka.ms/new-console-template for more information
using System;

class Customer
{
    private int id;
    private string name;
    private int discount;

    public Customer(int id, string name, int discount)
    {
        this.id = id;
        this.name = name;
        this.discount = discount;
    }

    public int GetId()
    {
        return id;
    }

    public string GetName()
    {
        return name;
    }

    public int GetDiscount()
    {
        return discount;
    }

    public void SetDiscount(int discount)
    {
        this.discount = discount;
    }

    public override string ToString()
    {
        return $"{name}({id})({discount}%)";
    }
}

class Invoice
{
    private int id;
    private Customer customer;
    private double amount;

    public Invoice(int id, Customer customer, double amount)
    {
        this.id = id;
        this.customer = customer;
        this.amount = amount;
    }

    public int GetId()
    {
        return id;
    }

    public Customer GetCustomer()
    {
        return customer;
    }

    public double GetAmount()
    {
        return amount;
    }

    public void SetAmount(double amount)
    {
        this.amount = amount;
    }

    public int GetCustomerId()
    {
        return customer.GetId();
    }

    public string GetCustomerName()
    {
        return customer.GetName();
    }

    public int GetCustomerDiscount()
    {
        return customer.GetDiscount();
    }

    public double GetAmountAfterDiscount()
    {
        return amount - (amount * customer.GetDiscount() / 100.0);
    }

    public override string ToString()
    {
        return $"Invoice[id={id},customer={customer},amount={amount}]";
    }
}

class TestMain
{
    static void Main(string[] args)
    {
        // Test Customer class
        Customer c1 = new Customer(88, "Tan Ah Teck", 10);
        Console.WriteLine(c1);

        c1.SetDiscount(8);
        Console.WriteLine(c1);
        Console.WriteLine("id is: " + c1.GetId());
        Console.WriteLine("name is: " + c1.GetName());
        Console.WriteLine("discount is: " + c1.GetDiscount());

        // Test Invoice class
        Invoice inv1 = new Invoice(101, c1, 888.8);
        Console.WriteLine(inv1);

        inv1.SetAmount(999.9);
        Console.WriteLine(inv1);
        Console.WriteLine("id is: " + inv1.GetId());
        Console.WriteLine("customer is: " + inv1.GetCustomer());
        Console.WriteLine("amount is: " + inv1.GetAmount());
        Console.WriteLine("customer's id is: " + inv1.GetCustomerId());
        Console.WriteLine("customer's name is: " + inv1.GetCustomerName());
        Console.WriteLine("customer's discount is: " + inv1.GetCustomerDiscount());
        Console.WriteLine("amount after discount is: " + inv1.GetAmountAfterDiscount().ToString("0.00"));
    }
}
