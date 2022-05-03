using FluentValidation;

namespace Library.Models.FluentValidators
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Zorunlu Alan");
            RuleFor(x => x.Name).MaximumLength(15).WithMessage("Maksimum 15 karakter girebilirsiniz");
            When(x => x.Name == "Deneme", () =>
            {
                RuleFor(x => x.PageCount).Must(y => y == "50").WithMessage("İsim deneme ise sayfa sayısı 50 olmalı");
            });
            RuleFor(x => x.PageCount).Must(y => int.TryParse(y,out int value)).WithMessage("Lütfen sayı ile ifade edin")
        }
    }
}
