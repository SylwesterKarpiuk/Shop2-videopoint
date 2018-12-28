using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop2_videopoint.Models
{
    public class Product : IEntity
    {
        [Required]
        [MaxLength(60),MinLength(3)]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
       // public virtual Category Category { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}