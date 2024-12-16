using InventoryIkeaApi.Models;

namespace InventoryIkeaApi.Services.Interfaces
{
    public interface IFurnitureService
    {
        Furniture GetFurnitureById(int id);
        IEnumerable<Furniture> GetAllFurniture();
    }
}
