using GearGo.Models;

namespace GearGo.Repositories
{
    public interface IEquipmentRepository
    {
        Task<IEnumerable<Equipment>> GetAllAsync();
        Task<Equipment?> GetByIdAsync(int id);
    }
}
