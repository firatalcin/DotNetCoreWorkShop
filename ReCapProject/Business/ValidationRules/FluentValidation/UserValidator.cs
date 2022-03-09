using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(b => b.FirstName).NotEmpty().WithMessage("Lütfen burayı doldurunuz.");
            RuleFor(b => b.LastName).NotEmpty().WithMessage("Lütfen burayı doldurunuz.");
            RuleFor(b => b.Email).NotEmpty().WithMessage("Lütfen burayı doldurunuz.");
            RuleFor(b => b.Password).NotEmpty().WithMessage("Lütfen burayı doldurunuz.");
        }
    }
}
