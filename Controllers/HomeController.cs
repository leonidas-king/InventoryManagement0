using InventoryManagement0.Data;
using InventoryManagement0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InventoryManagement0.Controllers
{
    //[Route("Action")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SignIn(Login obj)
        {
            var proof = _db.LoginTable.Find(1);
            String UserId = obj.UserName;
            String UserPass = obj.Password;


            if (proof.UserName==UserId && proof.Password==UserPass)
                return RedirectToAction("Index", "Inventory");

            return NotFound("Wrong Credentials.");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}