using FluentValidation;
using MvcWebUI.Models;
using System;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator : AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("Adı gereklidir.");
            RuleFor(s => s.FirstName).MinimumLength(2);
            RuleFor(s => s.Address).NotEmpty().When(s => s.Age < 18);
            RuleFor(s => s.FirstName).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
