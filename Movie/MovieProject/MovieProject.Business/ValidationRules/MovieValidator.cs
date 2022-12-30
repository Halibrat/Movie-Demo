using FluentValidation;
using MovieProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieProject.Business.ValidationRules
{
   public class MovieValidator:AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(u => u.Id).NotEmpty();
            RuleFor(u => u.Name).NotEmpty();
            RuleFor(u => u.Description).NotEmpty();
            RuleFor(u => u.Type).NotEmpty();
        }
    }
}
