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
        public IActionResult GetAllFurniture()
        {
            var furnitures = _furnitureService.GetAllFurniture();
            return Ok(furnitures);
        }

        [HttpGet("{id}")]
        public IActionResult GetFurnitureById(int id)
        {
            var furniture = _furnitureService.GetFurnitureById(id);
            if (furniture == null)
            {
                return NotFound();
            }

            return Ok(furniture);
        }
    }
}
