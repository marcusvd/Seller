using System;

namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public string Barcode { get; set; }
    }

}