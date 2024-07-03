using FluentValidation;
using PracticeShop.BLL.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.BLL.Validation.Product
{
    internal class UpdateProductDTOValidator : AbstractValidator<UpdateProductDTO>
    {

        public UpdateProductDTOValidator()
        {
            RuleFor(prod => prod.Id).NotEmpty().NotNull().WithMessage("invalid id");
            RuleFor(prod => prod.Name).NotEmpty().NotNull().MinimumLength(2).WithMessage("incorrect name");
            RuleFor(prod => prod.Cost).NotEmpty().NotNull().GreaterThan(0).WithMessage("incorrect cost");
            RuleFor(prod => prod.Description).NotEmpty().NotNull().MinimumLength(5).MaximumLength(200).WithMessage("incorrect descrtiption");
            RuleFor(prod => prod.CategoryId).NotNull().NotEmpty().WithMessage("invalid category");
        }
    }
}
