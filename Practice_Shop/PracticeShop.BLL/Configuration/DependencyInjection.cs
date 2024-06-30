using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using PracticeShop.BLL.DTOs;
using PracticeShop.BLL.Validation;

namespace PracticeShop.BLL.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddScoped<IValidator<OrderItemDTO>, OrderItemDTOValidator>();

            return services;
        }
    }
}
