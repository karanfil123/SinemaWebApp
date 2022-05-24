using FluentValidation;
using Sinemam.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemam.Service.Validations
{
    public class CommentDtoValidator:AbstractValidator<CommentDto>
    {
        public CommentDtoValidator()
        {
            RuleFor(x => x.Subject).NotEmpty().WithMessage("{PropertyName} adlı alan boş geçilemez");
            RuleFor(x => x.Content).NotEmpty().WithMessage("{PropertyName} adlı alan boş geçilemez");
            RuleFor(x => x.ShowId).InclusiveBetween(1, int.MaxValue).WithMessage("Zorunlu alan Show seçiniz.");
            RuleFor(x => x.UserId).InclusiveBetween(1, int.MaxValue).WithMessage("Zorunlu alan Kullanıcı seçiniz.");
        }
    }
}
