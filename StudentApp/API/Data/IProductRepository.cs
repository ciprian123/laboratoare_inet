using API.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Data
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        List<Product> FilterByPrice(float price);
        Product FindById(int id);
        List<Product> FilterByPrice(float start, float end);

        void UpdateProduct(Product product);

        void DeleteProduct(int id);
    }
}
