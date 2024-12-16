using System.ComponentModel.DataAnnotations;

namespace InventoryIkeaApi.Models
{
    public class FurnitureGroup
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Furniture> Furnitures { get; set;} = new List<Furniture>();
    }
}
