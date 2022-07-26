using System.ComponentModel.DataAnnotations;

namespace InventoryManagement0.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchasedDate { get; set; } = DateTime.Now;
        public DateTime ExpiringDate { get; set; } = DateTime.Now;
        public int Power { get; set; }
        public int MRP { get; set; }
        public int WHOL { get; set; }

    }
}
