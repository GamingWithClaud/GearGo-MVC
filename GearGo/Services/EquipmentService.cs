using System.Collections.Generic;
using System.Linq;
using GearGo.Models;
using GearGo.Repositories;

namespace GearGo.Services
{
    public class EquipmentService(EquipmentRepository repository)
    {
        public IEnumerable<Equipment> GetAll()
        {
            // Keep the controller independent of how equipment is stored.
            return repository.GetAllAsync();
        }

        public IEnumerable<Equipment> GetAvailable()
        {
            // Filter the repository results so callers receive only rentable items.
            return repository.GetAllAsync().Where(e => e.IsAvailable);
        }
    }
}