using Microsoft.Extensions.DependencyInjection;
using VogCodeChallenge.Infrastructure.DB.Connection;
using VogCodeChallenge.Infrastructure.DB.Repositories;
using VogCodeChallenge.Infrastructure.DB.Repositories.Interfaces;
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

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IConnectionFactory, ConnectionFactory>();
            services.AddScoped<IEmployeesRepository, EmployeesRepository>();

            return services;
        }
    }
}
