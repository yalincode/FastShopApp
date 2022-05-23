using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.DAL.Abstract
{
    public interface IGenericRepo<T>
    {
        IQueryable<T> GetAll(Func<T, bool> predicate = null);
        Task<T> GetById(int id);
        Task Add(T entity);
        Task Update(T entity);
        Task DeleteById(int id);
    }
}
