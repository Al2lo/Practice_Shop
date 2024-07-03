using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using PracticeShop.BLL.DTOs.Category;
using PracticeShop.BLL.Validation.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeShop.BLL.DTOs;
using PracticeShop.BLL.DTOs.Order;
using PracticeShop.BLL.DTOs.User;
using PracticeShop.BLL.Validation;
using PracticeShop.BLL.Validation.User;

namespace PracticeShop.BLL.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddScoped<IValidator<CreateCategory>, CreateCategoryValidator>();
            services.AddScoped<IValidator<OrderItemDTO>, OrderItemDTOValidator>();
            services.AddScoped<IValidator<OrderDTO>, OrderDTOValidator>();
            services.AddScoped<IValidator<UserDTO>, CreateUserValidator>();
            services.AddScoped<IValidator<UpdateUser>, UpdateUserValidator>();

            return services;
        }
    }
}
