using System;

namespace DomainModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime Available { get; set; }
        public double Price { get; set; }
        public int Rating { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
