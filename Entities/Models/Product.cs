using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "ProductName is required.")]
        public string? ProductName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; set; }
    }
}
