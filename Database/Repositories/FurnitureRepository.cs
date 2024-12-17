using InventoryIkeaApi.Database.Repositories.Interfaces;
using InventoryIkeaApi.Models;

namespace InventoryIkeaApi.Database.Repositories
{
    public class FurnitureRepository : IFurnitureRepository
    {
        private readonly List<Furniture> _furnitures = new List<Furniture>
        {
            new Furniture { Id = 1, Name = "Soffa Nevada", Price = 10000.00m, FurnitureGroup = new FurnitureGroup { Id = 1, Name = "Soffor" }, Status = new InventoryStatus { FurnitureId = 1, Status = "In Stock", Quantity = 10 } },
            new Furniture { Id = 2, Name = "Led-lampa", Price = 150.00m, FurnitureGroup = new FurnitureGroup { Id = 2, Name = "Belysning" }, Status = new InventoryStatus { FurnitureId = 2, Status = "Out of Stock", Quantity = 0 } }
        };

        public Task<Furniture> GetFurnitureById(int id, CancellationToken cancellationToken = default)
        {
            var furniture = _furnitures.FirstOrDefault(f => f.Id == id);
            return Task.FromResult(furniture);
        }

        public Task<IEnumerable<Furniture>> GetAllFurniture(CancellationToken cancellationToken = default)
        {
            return Task.FromResult<IEnumerable<Furniture>>(_furnitures);
        }
    }
}
