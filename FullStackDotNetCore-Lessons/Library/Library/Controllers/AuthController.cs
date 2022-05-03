using Library.Models;
using Library.RepositoryPattern.Abstract;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class AuthController : Controller
    {
        IRepository<AppUser> _repoUser;

        public AuthController(IRepository<AppUser> repoUser)
        {
            _repoUser = repoUser;
        }

        public IActionResult Login()
        {
            return View();
        }

        // veritabanında ilgili kullanıcı var mı ?
        // kullanıcının bilgileri çekicem
        // kullanıcının şifresi kriptolu veriyle eşleşiyor mu ?
        // kullanıcının rolune göre sayfa yönlendirmesi yapıcam.

        [HttpPost]
        public async Task<IActionResult> Login(AppUser user)
        {
            if (_repoUser.Any(x => x.UserName == user.UserName && x.Status != Enums.DataStatus.Delete))
            {
                var selectedUser = _repoUser.Default(x => x.UserName == user.UserName && x.Status != Enums.DataStatus.Delete);
                bool isValid = BCrypt.Net.BCrypt.Verify(user.Password, selectedUser.Password);
                if (isValid)
                {
                    List<Claim> claims = new List<Claim>()
                    {
                        new Claim("userName",selectedUser.UserName),
                        new Claim("userId", selectedUser.Id.ToString()),
                        new Claim("role",selectedUser.Role.ToString())
                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);
                    if (selectedUser.Role == Enums.Role.admin)
                    {
                        return RedirectToAction("Index", "Home", new { area = "Management" });
                    }
                    else if (selectedUser.Role == Enums.Role.user)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
