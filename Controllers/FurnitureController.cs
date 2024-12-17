using InventoryIkeaApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InventoryIkeaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FurnitureController : ControllerBase
    {
        private readonly IFurnitureService _furnitureService;

        public FurnitureController(IFurnitureService furnitureService)
        {
            _furnitureService = furnitureService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFurniture(int page = 1, int pageSize = 10, CancellationToken cancellationToken = default)
        {
            var furnitures = await _furnitureService.GetAllFurniture(page, pageSize, cancellationToken);
            return Ok(furnitures);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFurnitureById(int id, CancellationToken cancellationToken = default)
        {
            var furniture = await _furnitureService.GetFurnitureById(id, cancellationToken);
            if (furniture == null)
            {
                return NotFound();
            }

            return Ok(furniture);
        }
    }
}
