using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Product>> Get() => _repository.GetAllProducts().ToList();

        [HttpGet("find/{id}", Name = "FindById")]

        public ActionResult<Product> GetById(int id) => _repository.FindById(id);

        [HttpGet("filter/{price}", Name = "FilterByPrice")]
        public ActionResult<List<Product>> FilterByPrice(float price) => _repository.FilterByPrice(price);


        [HttpGet("{start,end}", Name = "FilterByPriceInRange")]
        public ActionResult<List<Product>> FilterByPriceInRange(float start, float end) => _repository.FilterByPrice(start, end);

        [HttpPut]
        public void UpdateProduct([FromBody] Product product) => _repository.UpdateProduct(product);

        [HttpDelete("{id}")]
        public void DeleteProduct(int id) => _repository.DeleteProduct(id);
    }
}