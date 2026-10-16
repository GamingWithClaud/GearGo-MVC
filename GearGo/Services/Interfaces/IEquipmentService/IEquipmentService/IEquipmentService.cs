using System.Collections.Generic;
using System.Threading.Tasks;
using GearGo.Models;

namespace GearGo.Services
{
    public interface IEquipmentService
    {
        Task<IEnumerable<Equipment>> GetAllEquipmentAsync();
        Task<IEnumerable<Equipment>> GetAvailableEquipmentAsync();
    }
}
