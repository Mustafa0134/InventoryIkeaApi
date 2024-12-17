using InventoryIkeaApi.Models;

namespace InventoryIkeaApi.Services.Interfaces
{
    public interface IFurnitureService
    {
        Task<Furniture> GetFurnitureById(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Furniture>> GetAllFurniture(int page, int pageSize, CancellationToken cancellationToken = default);
    }
}
