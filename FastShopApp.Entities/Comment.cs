using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.Entities
{
    public class Comment: BaseEntity
    {
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }

        public int ProductId { get; set; }
        public Product product { get; set; }

        //User
        public int UserId { get; set; }
        public AppUser user { get; set; }
    }
}
