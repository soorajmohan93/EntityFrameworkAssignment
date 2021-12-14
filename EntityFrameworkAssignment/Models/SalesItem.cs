using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkAssignment.Models
{
    public class SalesItem
    {
        [Key]
        public int SalesItemId { get; set; }

        [Required]
        public string SaleName { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


        public List<Product> Product { get; set; }
    }
}
