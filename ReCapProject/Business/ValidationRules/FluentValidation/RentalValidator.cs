using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(b => b.CarId).NotEmpty().WithMessage("Lütfen burayı doldurunuz.");
            RuleFor(b => b.CustomerId).NotEmpty().WithMessage("Lütfen burayı doldurunuz.");
            RuleFor(b => b.RentDate).NotEmpty().WithMessage("Lütfen burayı doldurunuz.");
        }
    }
}
