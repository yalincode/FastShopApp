using AutoMapper;
using FastShopApp.BL.Abstract;
using FastShopApp.BL.ValidatorRules;
using FastShopApp.Entities;
using FastShopApp.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FastShopApp.WebUI.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private IProductBusiness _productBusiness;
        public IMapper Mapper { get; }

        public ProductController(UserManager<AppUser> userManager, IProductBusiness productBusiness, IMapper mapper)
        {
            Mapper = mapper;
            _userManager = userManager;
            _productBusiness = productBusiness;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var user=await _userManager.FindByNameAsync(User.Identity.Name);
            var roles = await _userManager.GetRolesAsync(user);
            ViewBag.Roles = roles.FirstOrDefault();
            var products = _productBusiness.GetAll();
            List<string> productname = new List<string>();
            List<decimal> unitePrice = new List<decimal>();

            foreach (var product in products)
            {
                productname.Add(product.ProductName);
            }
            ViewBag.ProductsName = productname;

            foreach (var product in products)
            {
                unitePrice.Add(product.UnitPrice);
            }
            ViewBag.UnitePrice = unitePrice;
            return View(user);
        }

        [HttpGet("productadd")]
        public async Task<IActionResult> ProductCreate()
        {
            return View();
        }
        [HttpPost("productadd")]
        public async Task<IActionResult> ProductCreate(ProductCreateVM pvm)
        {
            var product=Mapper.Map<Product>(pvm);

            ProductValidator pv=new ProductValidator();
            var result=pv.Validate(product);
            if (result.IsValid)
            {
                product.BrandId = 1;
                product.CategoryId = 1;//optionları yapmaya zaman olmadığı için böyle ekledim
                product.BrandId = 1;
                await _productBusiness.Add(product);
                return RedirectToAction("ProductList","Product");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            
        }
    }
}
