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
using PracticeShop.BLL.Validation;

namespace PracticeShop.BLL.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddScoped<IValidator<CreateCategory>, CreateCategoryValidator>();
            services.AddScoped<IValidator<OrderItemDTO>, OrderItemDTOValidator>();

            return services;
        }
    }
}
