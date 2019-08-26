using Shop.DAL.Abstract;
using Shop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Concrate
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly EFContext _context = new EFContext();

        public IEnumerable<Product> Get()
        {
            return _context.Products.ToList();
        }
    }
}
