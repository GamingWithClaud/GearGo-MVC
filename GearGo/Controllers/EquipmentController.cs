using GearGo.Models;
using Microsoft.AspNetCore.Mvc;

namespace GearGo.Controllers
{
    public class EquipmentController : Controller
    {
        private static readonly List<Equipment> EquipmentList =
        [
            new Equipment { 
                Id = 1, 
                Name = "Tent", 
                Description = "A lightweight tent for camping." ,
                Category = "Shelter",
                ImageUrl = "https://images.unsplash.com/photo-1478131143081-80f7f84ca84d?auto=format&fit=crop&w=1000&q=85",
                DailyRate = 15.00m,
                IsAvailable = true
                },
            new Equipment { 
                Id = 2, 
                Name = "Sleeping Bag", 
                Description = "A warm sleeping bag for outdoor adventures." ,
                Category = "Camp comfort",
                ImageUrl = "https://images.unsplash.com/photo-1504280390367-361c6d9f38f4?auto=format&fit=crop&w=1000&q=85",
                DailyRate = 10.00m,
                IsAvailable = true
                },
            new Equipment { 
                Id = 3, 
                Name = "Backpack", 
                Description = "A durable backpack for hiking and travel." ,
                Category = "Packs",
                ImageUrl = "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?auto=format&fit=crop&w=1000&q=85",
                DailyRate = 20.00m,
                IsAvailable = true
                },
        ];

        public IActionResult Index()
        {
            return View(EquipmentList);
        }

        public IActionResult Details(int id)
        {
            var equipment = EquipmentList.FirstOrDefault(e => e.Id == id);

            if (equipment == null)
            {
                return NotFound();
            }

            return View(equipment);
        }
    }
}
