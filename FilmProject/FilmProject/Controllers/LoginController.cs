using FilmProject.Domain.Entities;
using FilmProject.Presistence.Contexts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FilmProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            if (ModelState.IsValid)
            {
                Context c = new Context();
                var login = c.Users.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
                if (login != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.UserName)
                    };
                    var useridentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Yonetim", new {area="Yonetim"});

                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}
