
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

Console.WriteLine(selectedProduct.Rank);


try
{
    selectedProduct.Discount = 100;



    Console.WriteLine(selectedProduct.Discount);

    selectedProduct.Discount = 700;


}
catch (ArgumentException e)
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
    //private string name;

    //public string Name
    //{
    //    set
    //    { 
    //        name = value; 
    //    }
    //    get
    //    {
    //        return name;
    //    }
    //}

    public string Name { get; set; }
    public string Description { get; set; }
    public string Barcode { get; set; }
    public decimal Price { get; set; }

    // scope (zakres widzialności)


    private decimal discount; // pole (back field)

    // Właściwość (property)
    public decimal Discount
    {
        // setter
        set
        {
            if (value > Price)
            {
                throw new ArgumentException("Wartość upustu nie może przekraczać ceny produktu.");
            }

            discount = value;
        }

        // getter
        get
        {
            return this.discount;
        }
    }


    /*
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
    */

    public string? color;

    private byte rank;

    public byte Rank 
    {
        get
        {
            return this.rank;
        }
    }

    public void IncrementRank()
    {
        if (rank < 5)
            rank++;
    }

    

    public bool isAvailable;
    //  public bool canDiscount;

    public Product(string name, string barcode, decimal price, byte rank = 1)
    {
        this.Name = name;
        this.Barcode = barcode;
        this.Price = price;
        this.rank = rank;

        this.isAvailable = true;
    }

    public void Display()
    {
        Console.WriteLine($"{Name} - cena {DiscountedPrice:N2}PLN {GetAsterix(rank)}");
    }

    // Właściwość tylko do odczytu (read-only)
    public decimal DiscountedPrice
    {
        get
        {
            return Price - discount;
        }
    }

    //public decimal GetDiscountedPrice()
    //{
    //    return Price - discount;
    //}

    public string GetAsterix(byte number)
    {
        return new string('*', number);
    }

}