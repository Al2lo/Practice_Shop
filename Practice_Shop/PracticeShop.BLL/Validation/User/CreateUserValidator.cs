using FluentValidation;
using PracticeShop.BLL.DTOs.User;

namespace PracticeShop.BLL.Validation.User
{
    public class CreateUserValidator : AbstractValidator<UserDTO>
    {
        public CreateUserValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).WithMessage("Incorrect name!");
            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Incorrect email!");
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8).Matches(@"[A-Z]+").Matches(@"[a-z]+").Matches(@"[0-9]+")
                                    .WithMessage("Incorrect password! It must contain lowercase and uppercase Latin characters and numbers " +
                                                 "and the password must be at least 8 characters long");
        }
    }
}
