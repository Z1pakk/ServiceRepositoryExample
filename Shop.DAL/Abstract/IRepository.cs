using Shop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Abstract
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();

        // TODO: Зробити інші методи
    }
}
