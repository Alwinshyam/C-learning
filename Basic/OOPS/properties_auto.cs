using System;


class Product
{
    public string name { get; set; }
    public string Category { get; } = "Electronics";
    public int price { get; private set; }

    public void updateAmount(int amount)
    {
        price += amount;
    }
}

class main
{
    static void Main()
    {
        Product product = new Product();
        product.name = "alwin";
        Console.WriteLine(product.name);
        Console.WriteLine(product.Category);
        product.updateAmount(1000);
        Console.WriteLine(product.price);
    }
}