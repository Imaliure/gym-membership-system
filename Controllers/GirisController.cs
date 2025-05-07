using Microsoft.AspNetCore.Mvc;

namespace SporSalonuUyeYonetim.Controllers
{
    public class GirisController : Controller
    {
        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/login")]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin123")
            {
                // Baþarýlý giriþ
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Hatalý giriþ
                ViewBag.ErrorMessage = "Geçersiz kullanýcý adý veya þifre.";
                return View();
            }
        }
    }
}
