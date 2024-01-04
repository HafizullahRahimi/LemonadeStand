using FluentValidation;
using LemonadeStand.Application.DTOs;

namespace LemonadeStand.BlazorApp.Validator
{
    public class OrderDtoValidator : AbstractValidator<OrderDto>
    {
        public OrderDtoValidator()
        {
            RuleFor(o => o.Recipe).NotNull().WithMessage("Choose a recipe").IsInEnum().WithMessage("Choose a recipe");
            RuleFor(o=> o.OrderedQuanity).NotNull().WithMessage("Select the quantity ordered").GreaterThan(0).WithMessage("Select the quantity ordered");
            RuleFor(o=> o.MoneyPaid).NotNull().WithMessage("Please pay").GreaterThan(0).WithMessage("Money paid only enough for 0 glass(es)!");
        }
    }
}
