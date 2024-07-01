using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using PracticeShop.BLL.DTOs;
using PracticeShop.BLL.DTOs.Product;
using PracticeShop.BLL.Validation;
using PracticeShop.BLL.Validation.Product;

namespace PracticeShop.BLL.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddScoped<IValidator<OrderItemDTO>, OrderItemDTOValidator>();
            services.AddScoped<IValidator<ProductDTO>, ProductDTOValidator>();
            services.AddScoped<IValidator<UpdateProductDTO>, UpdateProductDTOValidator>();

            return services;
        }
    }
}
