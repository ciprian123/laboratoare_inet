using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.Data
{
    class ProductRepository : IProductRepository
    {
        private readonly DataContext context;

        public ProductRepository(DataContext context)
        {
            this.context = context;
        }

        public void DeleteProduct(int id)
        {
            Product toDelete = FindById(id);
            context.Product.Remove(toDelete);
            context.SaveChanges();
        }

        public Product FindById(int id)
        {
            return context.Product.Find(id);
        }

        public List<Product> FilterByPrice(float price)
        {
            return context.Product.Where(product => price < product.price).ToList();
        }

        public List<Product> FilterByPrice(float start, float end)
        {
            return context.Product.Where(product => product.price >= start && product.price <= end).ToList();
        }

        public List<Product> GetAllProducts()
        {
            return context.Product.ToList();
        }

        public void UpdateProduct(Product product)
        {
            this.context.Update(product);
            this.context.SaveChanges();
        }
    }
}
