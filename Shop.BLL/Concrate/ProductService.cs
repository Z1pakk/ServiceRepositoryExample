using Shop.BLL.Abstract;
using Shop.BLL.Models;
using Shop.DAL.Abstract;
using Shop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BLL.Concrate
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;
        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }
        
        public IEnumerable<ProductDTO> GetAll()
        {
            return _repository.Get().Select(t => new ProductDTO()
            {
                Id = t.Id,
                Name = t.Name,
                Price = t.Price,
                DateCreate = t.DateCreate
            }).ToList();
        }
    }
}
