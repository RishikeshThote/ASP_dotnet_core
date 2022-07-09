using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_Project.Models
{
    public class Product
    {
        [key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        public float Price { get; set; }
        public string Brand { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
