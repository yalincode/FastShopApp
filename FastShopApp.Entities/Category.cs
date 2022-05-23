using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.Entities
{
    public class Category: BaseEntity
    {
        public Category()
        {
            products = new HashSet<Product>();
        }
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
