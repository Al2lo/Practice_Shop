using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using PracticeShop.BLL.DTOs.Category;
using PracticeShop.BLL.Validation.Category;
using PracticeShop.BLL.DTOs;
using PracticeShop.BLL.DTOs.Product;
using PracticeShop.BLL.Validation;
using PracticeShop.BLL.Validation.Product;
using PracticeShop.BLL.DTOs.Order;
using PracticeShop.BLL.DTOs.User;
using PracticeShop.BLL.Validation.User;
using PracticeShop.BLL.Services.Interfaces;
using PracticeShop.BLL.Services;

namespace PracticeShop.BLL.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();

            services.AddScoped<IValidator<CreateCategory>, CreateCategoryValidator>();
            services.AddScoped<IValidator<OrderItemDTO>, OrderItemDTOValidator>();
            services.AddScoped<IValidator<ProductDTO>, ProductDTOValidator>();
            services.AddScoped<IValidator<UpdateProductDTO>, UpdateProductDTOValidator>();
            services.AddScoped<IValidator<OrderDTO>, OrderDTOValidator>();
            services.AddScoped<IValidator<UserDTO>, CreateUserValidator>();
            services.AddScoped<IValidator<UpdateUser>, UpdateUserValidator>();

            services.AddScoped<IHashService, HashService>();

            return services;
        }
    }
}
