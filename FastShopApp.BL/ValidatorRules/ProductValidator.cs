using FastShopApp.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.BL.ValidatorRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün Adı boş geçilemez");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız");
        }
    }
}
