using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SVC_Supplier.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Brand { get; set; }
        public required string Department { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        public required string UnitsInLot { get; set; }
        public required string ImagePath { get; set; }
        public int SoldUnits { get; set; }
    }

    public class ProductDb
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Brand { get; set; }
        [Required]
        public required string Department { get; set; }
        [Required]
        public required string Description { get; set; }
        [Required]
        public required decimal Price { get; set; }
        [Required]
        public required string UnitsInLot { get; set; }
        [Required]
        public required string ImagePath { get; set; }
        public int SoldUnits { get; set; }
        
    }
}
