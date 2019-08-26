using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BLL.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public DateTime DateCreate { get; set; }
    }
}
