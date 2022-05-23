using FastShopApp.BL.Abstract;
using FastShopApp.DAL.Abstract;
using FastShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.BL.Concrete
{
    
    public class ProductBusiness : IProductBusiness
    {
        private IProductRepo _productRepo;

        public ProductBusiness(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task Add(Product entity)
        {
            await _productRepo.Add(entity);
        }

        public async Task DeleteById(int id)
        {
            await _productRepo.DeleteById(id);
        }

        public IQueryable<Product> GetAll(Func<Product, bool> predicate = null)
        {
            return _productRepo.GetAll(predicate);
        }

        public async Task<Product> GetById(int id)
        {
            return await _productRepo.GetById(id);
        }

        public async Task Update(Product entity)
        {
            await _productRepo.Update(entity);
        }
    }
}
