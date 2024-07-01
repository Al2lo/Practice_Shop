using FluentValidation;
using PracticeShop.BLL.DTOs.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.BLL.Validation
{
    public class OrderDTOValidator : AbstractValidator<OrderDTO>
    {
        public OrderDTOValidator() {
            RuleFor(x => x.Date)
                .NotNull()
                .Equal(DateTime.Today)
                .WithMessage("Incorrect date");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("User is not specified");
        }
    }
}
