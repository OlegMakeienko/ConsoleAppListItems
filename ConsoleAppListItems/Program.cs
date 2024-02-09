using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ProductList productList = new ProductList();
        string input;

        Console.WriteLine("Ange en produkt och dess pris (skriv 'q' för att avsluta):");

        while ((input = Console.ReadLine()) != "q")
        {
            try
            {
                var parts = input.Split(' ');
                var name = parts[0];
                var price = decimal.Parse(parts[1]);

                productList.AddProduct(new Product(name, price));
                Console.WriteLine("Produkt tillagd. Ange en annan produkt eller skriv 'q' för att avsluta:");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ett fel inträffade: {ex.Message}");
            }
        }

        Console.WriteLine("\nAlla inmatade produkter:");
        productList.DisplayProducts();
    }
}
