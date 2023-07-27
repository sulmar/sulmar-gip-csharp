
List<Product> products = new List<Product>
{
    new Product("Język C# od podstaw", "1234", 199.99m) { isAvailable = false },
    new Product("Szybka klawiatura", "1234", 239.99m),
    new Product("Język C# dla zaawansowanych", "1234", 599.99m),
    new Product("Szybka myszka", "1234", 199.99m),
};

products.Add(new Product("Język C# od podstaw", "1234", 99.99m) {  rank = 4 });
products.Add(new Product("Język C# od podstaw", "1234", 99.99m));

Product selectedProduct = products[2];
selectedProduct.rank++;
selectedProduct.rank++;
selectedProduct.rank++;
selectedProduct.rank++;
selectedProduct.rank++;
selectedProduct.rank++;


foreach (Product product in products)
{
    product.rank++;

    if (product.isAvailable)
    {
        product.Display();
    }   
}

class Product
{
    public string name;
    public string description;
    public string barcode;
    public decimal price;
    public decimal discount;
    public string? color;
    public byte rank;
    public bool isAvailable;
//  public bool canDiscount;

    public Product(string name, string barcode, decimal price)
    {
        this.name = name;
        this.barcode = barcode;
        this.price = price;

        this.isAvailable = true;
    }

    public void Display()
    {
        decimal actualPrice = GetDiscountedPrice();

        Console.WriteLine($"{name} - cena {actualPrice:N2}PLN {GetAsterix(rank)}");
    }

    public decimal GetDiscountedPrice()
    {
        return price - discount;
    }

    public string GetAsterix(byte number)
    {
        return new string('*', number);
    }

}