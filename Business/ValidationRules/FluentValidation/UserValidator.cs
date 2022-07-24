using System;
using Core.Entities.Concreate;
using Entity.Concreate;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty();
            RuleFor(c => c.FirstName).MaximumLength(2);

            RuleFor(c => c.LastName).NotEmpty();
            RuleFor(c => c.LastName).MaximumLength(2);
        }
    }
}

