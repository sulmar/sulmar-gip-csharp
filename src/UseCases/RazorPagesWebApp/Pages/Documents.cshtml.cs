using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesWebApp.Pages
{
    public class DocumentsModel : PageModel
    {
        [BindProperty]
        public List<Document> Documents { get; set; }

        public void OnGet()
        {
            Documents = new List<Document>
            {
                new Document { Title = "Lorem", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                new Document { Title = "Ipsum", Content = "Vel turpis nunc eget lorem dolor sed viverra ipsum nunc" },
                new Document { Title = "Dolor", Content = "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." },
                new Document { Title = "Turpis", Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur" },
                new Document { Title = "Excepteur", Content = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
            };
        }
    }


    public class Document
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
