using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MicrosoftAccessReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\path\\to\\your\\database.accdb;";

            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string sql = "...";
            OleDbCommand command = new OleDbCommand(sql);

            OleDbDataReader reader = command.ExecuteReader();
            
            while(reader.Read()) 
            {
                string name = reader.GetString(reader.GetOrdinal("Name"));                
            }

        }
    }
}
