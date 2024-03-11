using System.ComponentModel.DataAnnotations;

namespace SVC_Supplier.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public required int ProductId { get; set; }
        public required string Status { get; set; }
        public int Quantity { get; set; }
        public ProductModel Product { get; set; }
    }

    public class OrderDb
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required int ProductId { get; set; }
        [Required]
        public required string Status { get; set; }
        [Required]
        public required int Quantity { get; set; }

    }
}
