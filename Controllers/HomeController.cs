using InventoryManagement0.Data;
using InventoryManagement0.Models;
using Microsoft.AspNetCore.Authorization;
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

        public IActionResult GenAcc()
        {
            return View();
        }

        public IActionResult NewAcc(Login obj)
        {
            _db.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult SignIn(Login obj)
        {
            var proof = _db.LoginTable.Where(s => s.UserName==obj.UserName && s.Password==obj.Password);
            
            int n = proof.Count();

            if (n>0)
            {
                return RedirectToAction("Index", "Inventory");
            }

            return RedirectToAction("ErrorPage");

        }

        public IActionResult ErrorPage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}