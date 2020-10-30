using API.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Data
{
    public class ProductFactory
    {
        public static Product CreateProduct(int id, string name, float price, DateTime validFrom, DateTime validTo)
        {
            return new Product(id, name, price, validFrom, validTo);
        }
    }
}
