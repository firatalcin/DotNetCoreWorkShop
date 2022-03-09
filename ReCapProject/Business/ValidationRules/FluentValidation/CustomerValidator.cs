using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(b => b.UserId).NotEmpty().WithMessage("Lütfen burayı doldurunuz.");
            RuleFor(b => b.CompanyName).NotEmpty().WithMessage("Lütfen burayı doldurunuz.");
        }
    }
}
