using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Assignment3.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Do not leave the hair type category blank!")]
        
        public string Type { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}