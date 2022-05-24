
using FluentValidation;
using Sinemam.Core.Dtos;

namespace Sinemam.Service.Validations
{
    public class CategoryDtoValidator : AbstractValidator<CategoryDto>
    {
        public CategoryDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} alanı boş geçilemez.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("{PropertyName} alanı boş geçilemez.");
        }
    }
}
