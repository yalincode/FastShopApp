using AutoMapper;
using FastShopApp.Entities;
using FastShopApp.WebUI.Models;

namespace FastShopApp.WebUI.AutoMapper
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductCreateVM, Product>();
            CreateMap<Product, ProductCreateVM>();
        }
    }
}
