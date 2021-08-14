using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseGeneration.Models
{
    public class Order
    {
        [Key]
        public string OrderId { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public DateTime UpdatedTimestamp { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}