using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ColorId).NotEmpty().WithMessage("Lütfen burayı doldurunuz.");
            RuleFor(c => c.BrandId).NotEmpty().WithMessage("Lütfen burayı doldurunuz.");
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage("Lütfen burayı doldurunuz.");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Lütfen burayı doldurunuz.");
            RuleFor(c => c.ModelYear).NotEmpty().WithMessage("Lütfen burayı doldurunuz.");
        }
    }
}
