using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesWebApp.Pages
{
    [Authorize(Roles = "trainer, developer")]
    public class SecretModel : PageModel
    {        
        public void OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                // all data
            }
            else
            {
                // only public data
            }

            if (User.IsInRole("Trainer"))
            {

            }
                
        }

        [AllowAnonymous]
        public void About()
        {

        }


       
    }
}
