﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PracticeShop.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using PracticeShop.BLL.DTOs;
using PracticeShop.BLL.Validation;

namespace PracticeShop.DAL.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDAL(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            return services;
        }

        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddScoped<IValidator<OrderDTO>, OrderDTOValidator>();

            return services;
        }
    }
}
