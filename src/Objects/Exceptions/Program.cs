

SalaryCalculator salaryCalculator = new SalaryCalculator();

decimal result = salaryCalculator.Calculate(1000, 500, 3);

Console.WriteLine(result);

Weather weather = new Sunny(
            DateTime.Parse("2023-07-26 9:00"),
            DateTime.Parse("2023-07-26 16:00"),
            21.5f);


//while (true)
//{
//    Console.Write("Podaj temperaturę: ");
//    string temperatureString = Console.ReadLine();

//    int temperature = int.Parse(temperatureString);

//    try
//    {
//        Weather weather = new Weather(
//            DateTime.Parse("2023-07-26 9:00"),
//            DateTime.Parse("2023-07-26 16:00"),
//            temperature);

//        Console.WriteLine($"Aktualna temp. {temperature}C");
//    }
//    catch (ArgumentOutOfRangeException e)
//    {
//        Console.WriteLine("Przekroczony zakres");
//    }
//}


class Sunny : Weather
{
    public Sunny(DateTime from, DateTime to, float temperature) : base(from, to, temperature)
    {
    }
}

class Cloudy : Weather
{
    public CloudType cloudType;

    public Cloudy(DateTime from, DateTime to, float temperature) : base(from, to, temperature)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"{cloudType}");
    }
}


class Raining : Cloudy
{
    public int rainLevel;

    public Raining(DateTime from, DateTime to, float temperature) : base(from, to, temperature)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"{rainLevel} L/m2");
    }
}



abstract class Weather
{
    public Range range;
    public float temperature;
    public float humadity;

    public WeatherType weatherType;


    public Weather(DateTime from, DateTime to, float temperature)
    {
        // -60 .. 60
        if (temperature < -60 || temperature > 60)
        {
            throw new ArgumentOutOfRangeException(nameof(temperature));
        }

        this.range = new Range(from, to);
        this.temperature = temperature;
    }

    public virtual void Display()
    {
        Console.WriteLine($"{temperature}C {humadity}%");
    }


    //public void Print()
    //{
    //    if (weatherType == WeatherType.Sunny)
    //    {
    //        Console.WriteLine($"INSERT {temperature}C {humadity}%");
    //    }
    //    else if (weatherType == WeatherType.Raining)
    //    {
    //        Console.WriteLine($"INSERT {rainLevel} L/m2");
    //    }
    //    else if (weatherType == WeatherType.Cloudy)
    //    {
    //        Console.WriteLine($"INSERT {cloudType}");
    //    }
    //}

    //public void Display()
    //{
    //    if (weatherType == WeatherType.Sunny)
    //    {
    //        Console.WriteLine($"{temperature}C {humadity}%");
    //    }
    //    else if (weatherType == WeatherType.Raining)
    //    {
    //        Console.WriteLine($"{rainLevel} L/m2");
    //    }
    //    else if (weatherType == WeatherType.Cloudy)
    //    {
    //        Console.WriteLine($"{cloudType}");
    //    }
    //}
}

enum WeatherType
{
    Sunny,
    Cloudy,
    Raining
}

enum CloudType
{
    Pierzaste,
    Kolumbusy,
    Nieokreslone
}

class SalaryCalculator
{
    public decimal Calculate(decimal baseSalary, decimal bonusPerChild, byte numberOfChildren)
    {
        if (!(baseSalary > 0 && baseSalary < 1000_000))
        {
            throw new ArgumentOutOfRangeException(nameof(baseSalary));
        }

        if (!(bonusPerChild > 0))
        {
            throw new ArgumentOutOfRangeException(nameof(bonusPerChild));
        }

        if (!(numberOfChildren >= 0 && numberOfChildren < 20))
        {
            throw new ArgumentOutOfRangeException(nameof(bonusPerChild));
        }

        return baseSalary + bonusPerChild * numberOfChildren;
    }
}


struct Range
{
    public DateTime from;
    public DateTime to;

    public Range(DateTime from, DateTime to)
    {
        this.from = from;
        this.to = to;
    }
}
