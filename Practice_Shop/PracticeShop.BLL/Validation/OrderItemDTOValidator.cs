using FluentValidation;
using PracticeShop.BLL.DTOs;

namespace PracticeShop.BLL.Validation
{
    public class OrderItemDTOValidator : AbstractValidator<OrderItemDTO>
    {
        public OrderItemDTOValidator()
        {
            RuleFor(x => x.Amount).NotEmpty().InclusiveBetween(1, 20).WithMessage("Incorrect amount of products");
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("Product not specified");
        }
    }
}
