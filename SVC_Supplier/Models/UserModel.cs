using System.ComponentModel.DataAnnotations;

namespace SVC_Supplier.Models
{
    public class UserModel
    {
        public required string Name { get; set; }
        public required string SurName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string PasswordConfirmation { get; set; }
    }
    public class UserDb
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string SurName { get; set; }
        [Required]
        public required string Email { get; set; }
        [Required]
        public required string Password { get; set; }
    }
}
