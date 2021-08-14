using System.ComponentModel.DataAnnotations;

namespace DatabaseGeneration.Models
{
    public class Product
    {
        
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Currency { get; set; }
        
        public string Category { get; set; }
        
    }
}