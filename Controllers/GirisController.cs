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
                // Ba�ar�l� giri�
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Hatal� giri�
                ViewBag.ErrorMessage = "Ge�ersiz kullan�c� ad� veya �ifre.";
                return View();
            }
        }
    }
}
