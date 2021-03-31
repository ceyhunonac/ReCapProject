
using Entities1.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business1.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
    {
        RuleFor(c => c.CarId).NotEmpty();

        RuleFor(c => c.Description).NotEmpty();

        RuleFor(c => c.DailyPrice).NotEmpty();

        RuleFor(c => c.DailyPrice).GreaterThan(0);
        
    }
    }
}
