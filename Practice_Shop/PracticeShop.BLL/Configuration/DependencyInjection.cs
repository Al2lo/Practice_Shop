using Microsoft.Extensions.DependencyInjection;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.BLL.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
            return services;
        }
    }
}
