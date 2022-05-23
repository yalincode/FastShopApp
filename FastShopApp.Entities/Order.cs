using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.Entities
{
    public class Order: BaseEntity
    {
        //User
        public int UserId { get; set; }
        public AppUser user { get; set; }


        public int Quantity { get; set; }
        public decimal UnitePrice { get; set; }


        //Product
        public int ProductId { get; set; }
        public Product product { get; set; }
    }
}
