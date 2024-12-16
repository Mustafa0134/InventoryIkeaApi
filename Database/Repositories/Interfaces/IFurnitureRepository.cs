using InventoryIkeaApi.Models;

namespace InventoryIkeaApi.Database.Repositories.Interfaces
{
    public interface IFurnitureRepository
    {
        Furniture GetFurnitureById(int id);

        IEnumerable<Furniture> GetAllFurniture();
    }
}
