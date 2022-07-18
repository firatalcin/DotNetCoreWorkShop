using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("{PropertyName} boş geçilemez");
        }
    }
}