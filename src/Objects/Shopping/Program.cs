
List<Product> products = new List<Product>
{
    new Product("Język C# od podstaw", "1234", 199.99m) { isAvailable = false },
    new Product("Szybka klawiatura", "1234", 239.99m),
    new Product("Język C# dla zaawansowanych", "1234", 599.99m),
    new Product("Szybka myszka", "1234", 199.99m),
};

products.Add(new Product("Język C# od podstaw", "1234", 99.99m, 4));
products.Add(new Product("Język C# od podstaw", "1234", 99.99m));

Product selectedProduct = products[2];

selectedProduct.IncrementRank();
selectedProduct.IncrementRank();
selectedProduct.IncrementRank();
selectedProduct.IncrementRank();
selectedProduct.IncrementRank();
selectedProduct.IncrementRank();


try
{
    selectedProduct.SetDiscount(100);

    Console.WriteLine(selectedProduct.GetDiscount());

    selectedProduct.SetDiscount(700);

    
}
catch(ArgumentException e)
{
    Console.WriteLine(e.Message);
}


foreach (Product product in products)
{
    product.IncrementRank();

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
    
    // scope (zakres widzialności)

    // hermetyzacja danych
    private decimal discount; // pole (back field)
    
    // setter
    public void SetDiscount(decimal value)
    {
        if (value > price)
        {
            throw new ArgumentException("Wartość upustu nie może przekraczać ceny produktu.");
        }

        this.discount = value;
    }

    // getter
    public decimal GetDiscount()
    {
        return discount;
    }

    public string? color;
    
    private byte rank;

    public void IncrementRank()
    {
        if (rank < 5)
            rank++;
    }

    public bool isAvailable;
//  public bool canDiscount;

    public Product(string name, string barcode, decimal price, byte rank = 1)
    {
        this.name = name;
        this.barcode = barcode;
        this.price = price;
        this.rank = rank;

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