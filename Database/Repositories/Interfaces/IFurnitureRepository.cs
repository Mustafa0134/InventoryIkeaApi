using InventoryIkeaApi.Models;

namespace InventoryIkeaApi.Database.Repositories.Interfaces
{
    public interface IFurnitureRepository
    {
       Task <Furniture> GetFurnitureById(int id, CancellationToken cancellationToken = default);
       Task<IEnumerable<Furniture>> GetAllFurniture(CancellationToken cancellationToken = default);
    }
}
