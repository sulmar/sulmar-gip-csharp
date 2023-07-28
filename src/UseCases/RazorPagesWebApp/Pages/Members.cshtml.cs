using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Models;

namespace RazorPagesWebApp.Pages
{
    public class MembersModel : PageModel
    {
        [BindProperty]
        public List<Person> Members { get; set; }

        private readonly DbMemberRepository repository;

        public MembersModel()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSharpCourseDb;Integrated Security=True;";

            repository = new DbMemberRepository(new SqlConnection(connectionString));
        }

        public void OnGet()
        {
            Members = repository.Get();
        }
    }
}
