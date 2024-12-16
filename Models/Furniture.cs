using System.ComponentModel.DataAnnotations;

namespace InventoryIkeaApi.Models
{
    public class Furniture
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public required FurnitureGroup FurnitureGroup { get; set;}
        public required InventoryStatus Status { get; set; }
    }
}
