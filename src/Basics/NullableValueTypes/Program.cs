// Nullable Value Types

string? name = null;

if (name != null)
{
    Console.WriteLine(name);
}

byte? age = null;

if (age.HasValue)
{
    Console.WriteLine(age);
}
else
{
    Console.WriteLine("Wiek nieznany.");
}

decimal? salary = null;

if (salary.HasValue)
{
    Console.WriteLine(salary.Value);
}
else
{
    Console.WriteLine("Dochód nieznany.");
}

// TODO: nieskończoność
