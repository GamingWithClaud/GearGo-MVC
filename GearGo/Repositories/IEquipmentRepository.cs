using GearGo.Models;

namespace GearGo.Repositories
{
    public interface IEquipmentRepository
    {
        public IEnumerable<Equipment> GetAllAsync();

        Task<Equipment?> GetByIdAsync(int id);
    }
}