using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public AppUser()
        {
            comments=new HashSet<Comment>();
            orders=new HashSet<Order>();
        }
        [ValidateNever]
        [Display(Name = "Profil Resmi")]

        public string? ImageUrl { get; set; }

        [Required]
        [Display(Name = "İsim")]
        [MaxLength(255)]
        public string? Name { get; set; }


        [Required]
        [Display(Name = "Soyadı")]
        [MaxLength(255)]
        public string? Surname { get; set; }

        

        //Brand
        public int? BrandId { get; set; }
        public Brand brand { get; set; }

        //Comment
        public ICollection<Comment> comments { get; set; }

        //Order
        public ICollection<Order> orders { get; set; }
    }
}
