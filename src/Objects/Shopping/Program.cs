
List<Product> products = new List<Product>
{
    new Product("Język C# od podstaw", "1234", 199.99m) { IsAvailable = false },
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

    if (product.IsAvailable)
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

    
    public bool IsAvailable { get; set; }

    //  public bool canDiscount;

    public Product(string name, string barcode, decimal price, byte rank = 1)
    {
        this.Name = name;
        this.Barcode = barcode;
        this.Price = price;
        this.rank = rank;

        this.IsAvailable = true;
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


abstract class Base
{
    public DateTime CreateOn { get; set; }
    public DateTime? ModifiedOn { get; set; }
}

class Order : Base
{
    public DateTime OrderDate { get; set; }
    public DateTime ShippingDate { get; set; }
    public Customer Customer { get; set; }
    public Address ShippingAddress { get; set; }
    public OrderStatus Status { get; set; }
    public List<OrderDetail> Details { get; set; }

    public Order()
    {
        Details = new List<OrderDetail>();
    }

}

class OrderDetail : Base
{
    public Product Product { get; set; }    
    public int Quantity {  get; set; }
    public decimal Amount { get; set; }
    public decimal TotalAmount
    {
        get
        {
            return Quantity * Amount;
        }
    }

}

enum OrderStatus
{
    Registered,
    Picking,
    Shipping,
    Delivered,
}

class Customer : Base
{
    public Guid Id { get; set; }
    public string Number { get; set; }
    public string ShortName { get; set; }
    public string FullName { get; set; }
    public string TaxNumber { get; set; }
    public Address WorkAddress { get; set; }

    public Customer()
    {
        Id = Guid.NewGuid();
    }
}

public struct Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Postcode { get; set; }
    public string Country { get; set; }


}


// Zamówienie
// - dane teleadresowe klienta
// - adres dostawy
// - status realizacji
// - data zamówienia
// - data realizacji
// - sposób dostawy (glovo, paczkomat)
// - płatność
// - kwota całkowita
// - pozycje zamówienia
//     | nazwa | kod kreskowy | ilość | cena | wartość (ilość * cena)
