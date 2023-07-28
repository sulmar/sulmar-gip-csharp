using Microsoft.Data.SqlClient;
using Models;

namespace Infrastructure
{
    public class DbMemberRepository
    {
        private readonly SqlConnection connection;

        public DbMemberRepository(SqlConnection connection)
        {
            this.connection = connection;
        }

        public List<Person> Get()
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

    }
}