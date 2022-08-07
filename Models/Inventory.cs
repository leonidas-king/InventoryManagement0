using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagement0.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Item Name")]
        public string ItemName { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Please enter a valid number!")]
        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        public DateTime PurchasedDate { get; set; } = DateTime.Now;
        public DateTime ExpiringDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Please enter a valid number!")]
        [DisplayName("Power")]
        public int Power { get; set; }

        [Required(ErrorMessage = "Please enter a valid number!")]
        [DisplayName("MRP")]
        public int MRP { get; set; }

        [Required(ErrorMessage = "Please enter a valid number!")]
        [DisplayName("Wholesale")]
        public int WHOL { get; set; }

    }
}
