using System.ComponentModel.DataAnnotations;

namespace ProductWebAPI.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        public int Number { get; set; }
        public int Quantity { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        [Required]
        public decimal? Price { get; set; }

    }
}
