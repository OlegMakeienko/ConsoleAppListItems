class ProductList
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void DisplayProducts()
    {
        var sortedProducts = products.OrderBy(p => p.Price);

        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"{product.Name}: {product.Price}");
        }

        Console.WriteLine($"Total price: {sortedProducts.Sum(p => p.Price)}");
    }
}