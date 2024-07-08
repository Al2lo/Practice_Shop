using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.BLL.Validation.Order
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(o => o.UserId).GreaterThan(0).WithMessage("UserId must be greater than 0.");
            RuleFor(o => o.Date).NotEmpty().WithMessage("Order date must be set.");
        }
    }
}
