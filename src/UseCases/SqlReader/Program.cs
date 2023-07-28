using Models;

// ADO.NET

// CLI: dotnet add package Microsoft.Data.SqlClient

// namespace (przestrzeń nazw)

using Microsoft.Data.SqlClient;

string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSharpCourseDb;Integrated Security=True;";

Person newPerson = new Person
{
    Id = 6,
    FirstName = "John;DROP TABLE Users;",
    Company = "Domain",
    Position = "developer",
    Salary = 100.99m,
    Date = DateTime.Parse("2023-07-28")
};

SqlConnection connection = new SqlConnection(connectionString);

try
{   
    connection.Open();

    AddMember(connection, newPerson);

    List<Person> members = GetMembers(connection);

    foreach (Person person in members)
    {
        Console.WriteLine($"{person.Id} {person.FirstName} {person.Company} {person.Position} {person.Salary} {person.Date}");
    }   
}
catch(SqlException e)
{
    Console.WriteLine(e.Message);
}

finally
{
    connection.Close();
}


void AddMember(SqlConnection connection, Person person)
{
    // zła praktyka - podatność na atak typu SQL Injection
    //string addSql = $"INSERT INTO dbo.Members (MemberId, Firstname, Company, Position, Salary, [Date]) VALUES ({newPerson.Id}, 'John','Domain','developer',100.99,'2023-07-28')";

    // dobra praktyka - przekazywanie wartości poprzez parametry
    string sql = "INSERT INTO dbo.Members (MemberId, Firstname, Company, Position, Salary, [Date]) VALUES (@MemberId, @FirstName, @Company, @Position, @Salary, @Date)";

    SqlCommand addCommand = new SqlCommand(sql, connection);

    addCommand.Parameters.AddWithValue("@MemberId", person.Id);
    addCommand.Parameters.AddWithValue("@Firstname", person.FirstName);
    addCommand.Parameters.AddWithValue("@Company", person.Company);
    addCommand.Parameters.AddWithValue("@Position", person.Position);
    addCommand.Parameters.AddWithValue("@Salary", person.Salary);
    addCommand.Parameters.AddWithValue("@Date", person.Date);

    addCommand.ExecuteNonQuery();
}


List<Person> GetMembers(SqlConnection connection)
{
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

    return members;
}

