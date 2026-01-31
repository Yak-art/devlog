using DevLog.Application.Interfaces;
using DevLog.Infrastructure.Persistence;
using DevLog.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DevLog.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DevLogDbContext>(options => options.UseNpgsql(connectionString));

            services.AddScoped<IActivityRepository, ActivityRepository>();
            services.AddScoped<ITimeEntryRepository, TimeEntryRepository>();

            return services;
        }
    }
}
