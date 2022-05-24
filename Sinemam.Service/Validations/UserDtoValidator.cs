using FluentValidation;
using Sinemam.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemam.Service.Validations
{
    public class UserDtoValidator:AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("{PropertyName} adlı alan boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("{PropertyName} adlı alan boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("{PropertyName} adlı alan boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("{PropertyName} adlı alan boş geçilemez");
            RuleFor(x => x.Role).NotEmpty().WithMessage("{PropertyName} adlı alan boş geçilemez");
        }
    }
}
