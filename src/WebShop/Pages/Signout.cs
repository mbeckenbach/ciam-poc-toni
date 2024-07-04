using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebShop.Pages;

public class SignoutModel : PageModel
{
    public SignOutResult OnGet()
    {
        return SignOut("Cookies", "oidc");
    }
}
