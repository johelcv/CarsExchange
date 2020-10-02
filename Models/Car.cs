using System.ComponentModel.DataAnnotations;

namespace CarsExchange.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string make { get; set; }
        [Required]
        public string model { get; set; }
        [Required]
        public int year { get; set; }
    }
}