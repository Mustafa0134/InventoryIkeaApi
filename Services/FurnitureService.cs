using InventoryIkeaApi.Database.Repositories.Interfaces;
using InventoryIkeaApi.Models;
using InventoryIkeaApi.Services.Interfaces;

namespace InventoryIkeaApi.Services
{
    public class FurnitureService : IFurnitureService
    {
        private readonly IFurnitureRepository _furnitureRepository;
        private readonly IPaginationService _paginationService;

        public FurnitureService(IFurnitureRepository furnitureRepository, IPaginationService paginationService)
        {
            _furnitureRepository = furnitureRepository;
            _paginationService = paginationService;
        }

        public async Task<Furniture> GetFurnitureById(int id, CancellationToken cancellationToken = default)
        {
            return await _furnitureRepository.GetFurnitureById(id, cancellationToken);
        }

        public async Task<IEnumerable<Furniture>> GetAllFurniture(int page, int pageSize, CancellationToken cancellationToken = default)
        {
            var totalCount = await _furnitureRepository.GetAllFurniture(cancellationToken);

            return _paginationService.GetPage(totalCount, page, pageSize);   
        }
    }
}
