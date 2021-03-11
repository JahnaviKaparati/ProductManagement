using System;
using System.ComponentModel.DataAnnotations;

namespace DomainModels
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public DateTime Available { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
