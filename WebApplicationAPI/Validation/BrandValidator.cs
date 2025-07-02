using FluentValidation;
using WebApplicationAPI.DTO;

namespace WebApplicationAPI.Validation
{
    public class BrandValidator : AbstractValidator<CreateBrandDTO>
    {
        public BrandValidator()
        {
            RuleFor(n => n.Name).NotEmpty().WithMessage("Shorkan");
        }
    }
}
