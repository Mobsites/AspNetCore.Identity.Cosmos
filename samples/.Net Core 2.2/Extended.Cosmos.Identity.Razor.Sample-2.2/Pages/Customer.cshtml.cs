using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Extended.Cosmos.Identity.Razor.Sample_2._2.Pages
{
    [Authorize(Roles = "Admin, Customer")]
    public class CustomerModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
