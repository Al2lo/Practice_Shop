using FluentValidation;
using PracticeShop.BLL.DTOs.User;

namespace PracticeShop.BLL.Validation.User
{
    public class UpdateUserValidator : AbstractValidator<UpdateUser>
    {
        public UpdateUserValidator()
        {
            RuleFor(x => x.Balance).NotEmpty().GreaterThan(0f);
        }
    }
}
