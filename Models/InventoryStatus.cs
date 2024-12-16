using System.ComponentModel.DataAnnotations;

namespace InventoryIkeaApi.Models
{
    public class InventoryStatus
    {
        [Key]
        public int FurnitureId { get; set; }
        public string Status { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
}
