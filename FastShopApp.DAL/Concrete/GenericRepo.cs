using FastShopApp.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.DAL.Concrete
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        public Context _Db { get; set; }
        public GenericRepo(Context Db)
        {
            _Db = Db;
        }
        public virtual async Task Add(T entity)
        {
            await _Db.Set<T>().AddAsync(entity);
            await _Db.SaveChangesAsync();
        }

        public virtual async Task DeleteById(int id)
        {
            var entity = await GetById(id);
            _Db.Set<T>().Remove(entity);
            await _Db.SaveChangesAsync();
        }

        public virtual IQueryable<T> GetAll(Func<T, bool> predicate = null)
        {
            var DbSet = _Db.Set<T>().AsQueryable();
            if (predicate != null)
            {
                DbSet = DbSet.Where(predicate).AsQueryable();
            }
            return DbSet;
        }

        public virtual async Task<T> GetById(int id)
        {
            return await _Db.Set<T>().FindAsync(id);
        }

        public virtual async Task Update(T entity)
        {
            _Db.Set<T>().Update(entity);
            await _Db.SaveChangesAsync();
        }
    }
}
