using GearGo.Models;
using GearGo.Services;
using Microsoft.AspNetCore.Mvc;

namespace GearGo.Controllers
{
    public class EquipmentController(EquipmentService service) : Controller
    {
        // ASP.NET Core supplies this service through dependency injection.
        private readonly EquipmentService _service = service;

        public IActionResult Index()
        {
            // Show the full equipment list using the Index view.
            var list = _service.GetAll();
            return View(list);
        }

        public IActionResult Available()
        {
            // Reuse the Index view, but pass it only equipment marked as available.
            var available = _service.GetAvailable();
            return View("Index", available);
        }

        public IActionResult Details(int id)
        {
            // Find the requested item; return a 404 response if its ID does not exist.
            var equipment = _service.GetAll().FirstOrDefault(e => e.Id == id);

            if (equipment == null)
            {
                return NotFound();
            }

            return View(equipment);
        }
    }
}