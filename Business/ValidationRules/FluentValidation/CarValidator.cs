using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarId).NotEmpty();
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.ModelYear).GreaterThan(2018);
            RuleFor(c => c.DailyYear).GreaterThan(2021);
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.BrandId).Equal(1).When(c => c.ColorId == 2);
            RuleFor(c => c.CarName).Must(StartWithA).WithMessage("Araba ismi A harfi ile başlamalı");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
