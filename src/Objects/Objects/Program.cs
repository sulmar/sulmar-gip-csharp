// Objects

//string firstName1 = "Marcin";
//string lastName1 = "Sulecki";
//string city1 = "Bydgoszcz";
//byte experience1 = 25;
//string position1 = "trainer";
//string make1 = "Mazda";
//string model1 = "6";
//string vin1 = "1234";
//string make2 = "Mazda";
//string model2 = "6";
//string vin2 = "45678";

// utwórz obiekt (instancję klasy)
Person person1 = new Man()
{                               // Inicjalizator
    firstName = "Marcin",
    lastName = "Sulecki",
    city = "Bydgoszcz",
    experience = 25,
    position = "trainer"
};

Console.WriteLine(person1.lastName.Length);

//person1.firstName = "Marcin";
//person1.lastName = "Sulecki";
//person1.city = "Bydgoszcz";
//person1.experience = 25;
//person1.position = "trainer";

Person person2 = new Woman() { lastName = "Kudlińska", maidenName = "Andrzejewska" };
person2.firstName = "Agnieszka";

// person2.lastName = "Kudlińska";
person2.city = "Konin";
person2.experience = 20;
person2.position = "boss";
person2.DoWork();

Person person3 = new Man() { lastName = "Brygier" };
person3.firstName = "Damian";
// person3.lastName = "Brygier";
person3.city = "Czempiń";
person3.experience = 12;
person3.position = "developer";
person3.DoWork();

// person1.Display();
person3.Display();
person2.Display();


Vehicle vehicle1 = new Vehicle("Mazda", "6", "1234", "Blue",  VehicleType.Car,  FuelType.Oil, GearBoxType.Automatic);
Vehicle vehicle2 = new Vehicle("Toyota", "Avensis", "4313") { gearBoxType = GearBoxType.Automatic };

vehicle1.Display();
vehicle2.Display();


//Display(firstName1, lastName1, city1, experience1, position1);
//Display(firstName2, lastName2, city2, experience2, position2);
//Display(firstName3, lastName3, city3, experience1, position2);


//void Display(string firstName, string lastName, string city, byte experience, string position)
//{
//    Console.WriteLine($"{firstName} {lastName} from {city} has {experience} years experience, work as {position}");
//}

// Klasa - typ, który zawiera cechy (atrybuty) i czynności, które mogą być realizowane na tych atrybutach.




abstract class Person
{
    public string firstName;
    public required string lastName;
    public string city;
    public byte experience;
    public string position;

    public Gender gender;


    // Polimorfizm (wielopostaciowość)
    //public string GetFullName()
    //{
    //    return $"{firstName} {lastName}";
    //}

    // Polimorfizm (wielopostaciowość)

    public virtual void Display()
    {
        Console.WriteLine($"{firstName} {lastName} from {city} has {experience} years experience, work as {position}");
    }

    //public void DoWork()
    //{
    //    if (gender == Gender.Male)
    //    {
    //        Console.WriteLine("Pracuje mężczyzna...");
    //    }
    //    else if (gender == Gender.Female)
    //    {
    //        Console.WriteLine("Pracuje kobieta...");
    //    }
    //}

    public void DoWork()
    {
        Console.WriteLine("Pracuje osoba...");
    }
}

// Dziedziczenie
class Man : Person
{
    public void DoWork()
    {
        Console.WriteLine("Pracuje mężczyzna...");
    }   
}

class Woman : Person
{
    public string maidenName; // nazwisko panienskie

    public void DoWork()
    {
        Console.WriteLine("Pracuje kobieta...");
    }

    //public string GetFullName()
    //{
    //    return $"{firstName} {lastName} ({maidenName})";
    //}

    public override void Display()
    {
        Console.WriteLine($"{firstName} {lastName} ({maidenName}) from {city} has {experience} years experience, work as {position}");
    }


}

enum Gender
{
    Male,
    Female
}



// W C# nie ma wielodziedziczenia
//class Amfibia : Pojazd, Lodz
//{

//}

class Vehicle
{
    public string make;
    public string model;
    public string vin;
    public string color;

    public int maxSpeed;

    public VehicleType type;
    public FuelType fuelType;
    public GearBoxType gearBoxType;

    // Konstruktor (constructor) - służy do skonstruowania obiektu
    public Vehicle(string make, string model, string vin, string color, VehicleType vehicleType, FuelType fuelType, GearBoxType gearBoxType)
    {
        this.make = make;
        this.model = model;
        this.vin = vin;
        this.color = color;
        this.type = vehicleType;
        this.fuelType  = fuelType;
        this.gearBoxType = gearBoxType;

        maxSpeed = 240;
    }

   
    public Vehicle(string make, string model, string vin)
        : this(make, model, vin, "White", VehicleType.Car, FuelType.Oil, GearBoxType.Manual)
    {
    }

    public void Run()
    {
        if (type == VehicleType.Car)
        {

        }
        else if (type == VehicleType.Truck)
        {

        }
        else
        {
            // ...
        }
    }

    public void Display()
    {
        Console.WriteLine($"{make} {model} {vin} {color} {maxSpeed} {type} {fuelType} {gearBoxType}");
    }

}

enum VehicleType
{
    Car,
    Truck,
    Bus
}

enum FuelType
{
    Oil,
    Gas,
    Electric
}

enum GearBoxType
{
    Manual,
    Automatic
}

// MichałH: Mebel (typ mebla, przeznaczenie, wymiary, kolor, materiał, wiszące/stojące, styl, stan, rodzaj zawiasów szafki, krzesło obrotowe/nieobrotowe)
// Michał: Pogoda (rodzaj pogody, zachmurzenie, temperatura, wilgotność, ciśnienie, lokalizacja, zjawisko atmosferyczne, rodzaj opadów)
// Agnieszka: Buty (typ, kolor,rozmiar, materiał, klasyfikacja, płeć, rok produkcji, wodoodporność butów trackingowych, klasa ochronności przy butach ochronnych, sprężystość do butów sportowych)
// Damian: Posiłek (data przygotowania, rodzaj, składniki, rodzaj obróbki, kaloryczność, typ (vege, mięsny, wegetariański), czas przygotowania, alergeny)



