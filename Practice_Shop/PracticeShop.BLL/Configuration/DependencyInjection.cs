using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using PracticeShop.BLL.DTOs.Category;
using PracticeShop.BLL.Validation.Category;
using System.Threading.Tasks;
using PracticeShop.BLL.DTOs;
using PracticeShop.BLL.DTOs.Product;
using PracticeShop.BLL.Validation;
using PracticeShop.BLL.Validation.Product;
using PracticeShop.BLL.DTOs.Order;
using PracticeShop.BLL.DTOs.User;
using PracticeShop.BLL.Validation.User;
using PracticeShop.BLL.Services.Interfaces;
using PracticeShop.BLL.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;


namespace PracticeShop.BLL.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBLL(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IValidator<CreateCategory>, CreateCategoryValidator>();
            services.AddScoped<IValidator<OrderItemDTO>, OrderItemDTOValidator>();
            services.AddScoped<IValidator<ProductDTO>, ProductDTOValidator>();
            services.AddScoped<IValidator<UpdateProductDTO>, UpdateProductDTOValidator>();
            services.AddScoped<IValidator<OrderDTO>, OrderDTOValidator>();
            services.AddScoped<IValidator<UserDTO>, CreateUserValidator>();
            services.AddScoped<IValidator<UpdateUser>, UpdateUserValidator>();
            services.AddScoped<ITokenService, TokenService>();

            var jwtOptions = configuration.GetSection(nameof(JwtOptions)).Get<JwtOptions>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateAudience = true,
                        ValidateIssuer = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.SecretKeyAccess))
                    };

                    options.Events = new JwtBearerEvents
                    {
                        OnMessageReceived = context =>
                        {
                            context.Token = context.Request.Cookies["access-token"];

                            return Task.CompletedTask;
                        }
                    };
                });

            services.AddScoped<IHashService, HashService>();

            return services;
        }
    }
}
