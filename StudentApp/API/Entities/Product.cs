using System;

namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string product_name { get; set; }

        public float price { get; set; }

        public DateTime? valid_from { get; set; }

        public DateTime? valid_to { get; set; }

        public Product()
        {

        }

        public Product(int id, string name, float product_price, DateTime validFrom, DateTime validTo)
        {
            Id = id;
            product_name = name;
            price = product_price;
            valid_from = validFrom;
            valid_to = valid_to;
        }
    }
}
