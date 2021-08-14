using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseGeneration.Models
{
    public class Product
    {
        [Key]   
        public int ProductId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Currency { get; set; }
        
        public string Category { get; set; }
        
        public List<Order> Orders { get; set; }
        
    }
}