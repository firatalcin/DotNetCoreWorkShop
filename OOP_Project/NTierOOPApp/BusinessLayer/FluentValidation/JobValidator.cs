using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation
{
    public class JobValidator : AbstractValidator<Job>
    {
        public JobValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Bu alan boş geçilemez");
        }
    }
}