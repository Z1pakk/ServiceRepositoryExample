using Shop.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BLL.Abstract
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetAll();
    }
}
