using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebShop.Pages;

[Authorize]
public class LoginModel : PageModel
{
    private readonly ILogger<LoginModel> _logger;

    public LoginModel(ILogger<LoginModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        if(User.Identity?.IsAuthenticated == true) {
            Response.Redirect("/");
        }
    }
}

