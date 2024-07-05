using CardGame.WebAPI.Configuration.Error_Handling;

namespace PracticeShop.WebAPI.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAPI(this IServiceCollection services)
        {
            services.AddExceptionHandler<NotFoundExceptionHandler>();
            services.AddExceptionHandler<BadRequestExceptionHandler>();
            services.AddProblemDetails();
            return services;
        }
    }
}
