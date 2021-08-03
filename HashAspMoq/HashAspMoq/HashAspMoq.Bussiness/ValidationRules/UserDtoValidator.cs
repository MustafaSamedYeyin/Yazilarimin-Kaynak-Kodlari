using FluentValidation;
using HashAspMoq.Dtos.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashAspMoq.Bussiness.ValidationRules
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(i => i.Name).NotEmpty();
            RuleFor(i => i.Age).NotEmpty().ExclusiveBetween(18, 250);
        }
    }
}
