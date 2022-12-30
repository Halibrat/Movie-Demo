using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieProject.Business.ValidationRules
{
   public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Id).NotEmpty();
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.PasswordHash).NotEmpty();
            RuleFor(u => u.PasswordSalt).NotEmpty();
            RuleFor(u => u.Status).NotEmpty();
        }
    }
}
