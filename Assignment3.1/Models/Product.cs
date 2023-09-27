using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Assignment3.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Shampoo name cannot be blank")]
       
        public string Name { get; set; }

        [Required(ErrorMessage = "The Shampoo brand cannot be blank")]
       
        public string Brand { get; set; }

        [Required(ErrorMessage = "The Shampoo Description cannot be blank")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The Shampoo price cannot be blank")]
       
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The Image URL cannot be blank")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = "The Image alternative text cannot be blank")]
        public string ImageAlternativeText { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}