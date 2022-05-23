using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.Entities
{
    public class Product: BaseEntity
    {
        public Product()
        {
            comments = new HashSet<Comment>();
        }
        public string ProductName { get; set; }
        public string? ProductImage { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }
        
        public decimal UnitPrice { get; set; }

        //Category
        public int? CategoryId { get; set; } = null;
        public Category category { get; set; }

        //Comment
        public ICollection<Comment> comments { get; set; }

        //Brand
        public int? BrandId { get; set; } = null;
        public Brand brand { get; set; }

    }
}
