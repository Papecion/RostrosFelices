using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RostrosFelices.Models;
using System.Security.Claims;

namespace RostrosFelices.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,"/*****/"),
                    new Claim(ClaimTypes.Email, User.Email),
                };
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
    

