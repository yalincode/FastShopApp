using FastShopApp.DAL.Abstract;
using FastShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.DAL.Concrete
{
    public class EfProductRepo:GenericRepo<Product>,IProductRepo
    {
        public EfProductRepo(Context Db) : base(Db)
        {

        }
    }
}
