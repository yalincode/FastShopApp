using FastShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.BL.Abstract
{
    public interface IProductBusiness
    {
        IQueryable<Product> GetAll(Func<Product, bool> predicate = null);

        Task<Product> GetById(int id);
        Task Add(Product entity);
        Task Update(Product entity);
        Task DeleteById(int id);
    }
}
