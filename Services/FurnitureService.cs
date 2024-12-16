using InventoryIkeaApi.Database.Repositories.Interfaces;
using InventoryIkeaApi.Models;
using InventoryIkeaApi.Services.Interfaces;

namespace InventoryIkeaApi.Services
{
    public class FurnitureService : IFurnitureService
    {
        private readonly IFurnitureRepository _furnitureRepository;

        public FurnitureService(IFurnitureRepository furnitureRepository)
        {
            _furnitureRepository = furnitureRepository;
        }

        public Furniture GetFurnitureById(int id)
        {
            return _furnitureRepository.GetFurnitureById(id);
        }
        public IEnumerable<Furniture> GetAllFurniture()
        {
            return _furnitureRepository.GetAllFurniture();
        }
    }
}
