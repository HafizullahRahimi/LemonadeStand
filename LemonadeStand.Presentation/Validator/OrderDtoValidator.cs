using FluentValidation;
using LemonadeStand.Application.DTOs;

namespace LemonadeStand.Presentation.Validator
{
    public class OrderDtoValidator : AbstractValidator<OrderDto>
    {
        public OrderDtoValidator()
        {
            RuleFor(o => o.Recipe).IsInEnum().WithMessage("Choose a recipe");
            RuleFor(o => o.OrderedQuanity).NotNull().WithMessage("Ordered Quanity must not be empty").GreaterThan(0).WithMessage("Select the quantity ordered");
            RuleFor(o => o.MoneyPaid).NotNull().WithMessage("Money Paid must not be empty").GreaterThan(0).WithMessage("Money paid only enough for 0 glass(es)!");
        }
    }
}
