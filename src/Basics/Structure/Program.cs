
string street = "Dworcowa";
string city = "Poznań";
string country = "Poland";
string postalCode = "00-000";
int capacity = 500_000;
DateOnly buildDate = DateOnly.Parse("1400-01-01");

Address shippingAddress = new Address();
shippingAddress.Street = street;
shippingAddress.City = city;
shippingAddress.Country = country;
shippingAddress.PostalCode = postalCode;
shippingAddress.Capacity = capacity;
shippingAddress.BuildDate = buildDate;

Console.WriteLine($"{shippingAddress.Street} {shippingAddress.City} {shippingAddress.Country}");


struct Address
{
    public string Street;    
    public string City;
    public string Country;
    public string PostalCode;
    public int Capacity;
    public DateOnly BuildDate;
}

struct Location
{
    public double Latitude;
    public double Longitude;
}