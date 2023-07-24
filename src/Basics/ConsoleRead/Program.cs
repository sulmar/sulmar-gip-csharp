
Console.Write("Podaj imię: ");
string firstName = Console.ReadLine();

// TODO: Pobierz i wyświetl drugie imię (secondname)

Console.Write("Podaj drugie imię: ");
string secondName = Console.ReadLine();

Console.Write("Podaj nazwisko: ");
string lastName = Console.ReadLine();

string message = $"Hello {firstName} {secondName} {lastName}";
Console.WriteLine(message);
