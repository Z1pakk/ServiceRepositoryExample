using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Entities
{
    public class EFContext:DbContext
    {
        public EFContext():base("BuchokConnection")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
