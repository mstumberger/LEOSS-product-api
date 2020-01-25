using System;

namespace Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime AddedAt { get; set; }
        public string Supplyer { get; set; }
        public string Barcode { get; set; }
    }
}
