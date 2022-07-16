using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün adı en az 3 karakter olmalıdır");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Bu alan boş geçilemez");
        }
    }

    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("{PropertyName} boş geçilemez");
        }
    }
}