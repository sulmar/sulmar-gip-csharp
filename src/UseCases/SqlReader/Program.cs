
// CLI: dotnet add package Microsoft.Data.SqlClient

// namespace (przestrzeń nazw)


using Microsoft.Data.SqlClient;

string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSharpCourseDb;Integrated Security=True;";

try
{
    SqlConnection connection = new SqlConnection(connectionString);

    connection.Open();

    string sql = "SELECT MemberId, Firstname, Company, Position, Salary, Date FROM dbo.Members";

    SqlCommand command = new SqlCommand(sql, connection);

    SqlDataReader reader = command.ExecuteReader();

    List<Person> members = new List<Person>();

    while (reader.Read())
    {
        int memberId = reader.GetInt32(reader.GetOrdinal("MemberId"));
        string firstName = reader.GetString(reader.GetOrdinal("Firstname"));
        string company = reader.GetString(reader.GetOrdinal("Company"));
        string position = reader.GetString(reader.GetOrdinal("Position"));
        decimal salary = reader.GetDecimal(reader.GetOrdinal("Salary"));
        DateTime date = reader.GetDateTime(reader.GetOrdinal("Date"));

        Person person = new Person();
        person.Id = memberId;
        person.FirstName = firstName;
        person.Company = company;
        person.Position = position;
        person.Salary = salary;
        person.Date = date;

        members.Add(person);
    }

    foreach (Person person in members)
    {
        Console.WriteLine($"{person.Id} {person.FirstName} {person.Company} {person.Position} {person.Salary} {person.Date}");
    }
}
catch(SqlException e)
{
    Console.WriteLine(e.Message);
}

abstract class Base
{
    public int Id { get; set; }
}

class Person : Base
{
    public string FirstName { get; set; }
    public string Company { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; } 
    public DateTime Date { get; set; }
}

