using FluentValidation;
using Sinemam.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemam.Service.Validations
{
    public class ShowDtoValidator : AbstractValidator<ShowDto>
    {
        public ShowDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} adlı alan boş geçilemez.");
            RuleFor(x => x.Year).InclusiveBetween(1900, 2100).WithMessage(" {PropertyName}  1900-2100 yıllar arasında olmalıdır .");
            RuleFor(x => x.Director).NotEmpty().WithMessage("{PropertyName} adlı alan boş geçilemez.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("{PropertyName} adlı alan boş geçilemez.");
            RuleFor(x => x.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("Zorunlu alan kategori seçiniz.");
            RuleFor(x => x.MinuteSize).InclusiveBetween(1, 1000).WithMessage(" {PropertyName} en az 1-1000 dakika  arasında olmalıdır .");
            RuleFor(x => x.Country).NotEmpty().WithMessage("{PropertyName} adlı alan boş geçilemez.");
            RuleFor(x => x.Imdb).InclusiveBetween(1, 10).WithMessage(" {PropertyName} en az 1-10 arasında olmalıdır .");
        }
    }
}
