using InventoryManagement0.Data;
using InventoryManagement0.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement0.Controllers
{
    
    public class InventoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public InventoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Inventory> objInventoryList = _db.InventoryTable;
            return View(objInventoryList);
        }

        public IActionResult Create()
        {
                return View();
        }

        [HttpPost]
        public IActionResult Create(Inventory obj)
        {
            
            if (ModelState.IsValid)
            {
                TempData["Msg"] = "Item added successfully.";
                _db.InventoryTable.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
            
        }

        public IActionResult Edit(int? id)
        {
            
            if (id == null || id == 0)
                return NotFound();

            var Result = _db.InventoryTable.Find(id);

            if (Result == null)
                return NotFound();
            return View(Result);
            
        }

        
        [HttpPost]
        public IActionResult Edit(Inventory obj)
        {
            
            TempData["Msg"] = "Item edited successfully.";
            _db.InventoryTable.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            
        }

        public IActionResult DeleteItem(int? id)
        {
            
            if (id == 0 || id == null)
                return NotFound();
            var item = _db.InventoryTable.Find(id);
            if (item == null)
                return NotFound();
            return View(item);
            
            
        }

        [HttpPost]
        public IActionResult DeletePOST(int? id)
        {
            
            TempData["Msg"] = "Item deleted successfully.";
            var item = _db.InventoryTable.Find(id);
            if (item == null)
                return NotFound();
            _db.InventoryTable.Remove(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
            
            
        }
    }
}
