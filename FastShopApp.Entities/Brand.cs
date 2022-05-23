using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.Entities
{
    public class Brand: BaseEntity
    {
        public Brand()
        {
            products = new HashSet<Product>();
        }
        public string BrandName { get; set; }
        public string BrandAbout { get; set; }
        
        public ICollection<AppUser> users { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
