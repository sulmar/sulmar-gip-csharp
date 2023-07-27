

string fileName = @"C:\temp\gip\members.csv";

// string text = File.ReadAllText(fileName);
// Console.WriteLine(text);

const char separator = ';';

string[] lines = File.ReadAllLines(fileName);

List<Person> members = new List<Person>();

foreach (string line in lines.Skip(1))
{
    string[] columns = line.Split(separator);

    Person member = Map(columns);
        
    members.Add(member);
}


foreach (Person member in members)
{
    Console.WriteLine($"{member.FirstName} {member.CompanyName} {member.Position} {member.Salary:C2} {member.Date}");
}

// TODO: Wyślij maila do wszystkich uczestników

// TODO: Wygeneruj plik PDF

Person Map(string[] columns)
{
    Person person = new Person();
    person.FirstName = columns[0];
    person.CompanyName = columns[1];
    person.Position = columns[2];
    person.Salary = decimal.Parse(columns[3]);
    person.Date = DateTime.Parse(columns[4]);
    return person;
}

// firstname;company;position;salary;date
class Person
{
    public string FirstName { get; set; }
    public string CompanyName { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public DateTime Date { get; set; }
    
}








