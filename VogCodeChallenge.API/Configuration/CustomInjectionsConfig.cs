using Microsoft.Extensions.DependencyInjection;
using VogCodeChallenge.Services.Services;
using VogCodeChallenge.Services.Services.Interfaces;

namespace VogCodeChallenge.API.Configuration
{
    public static class CustomInjectionsConfig
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();

            return services;
        }
    }
}
