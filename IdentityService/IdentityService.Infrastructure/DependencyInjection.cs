using IdentityService.Core.Common.Interfaces;
using IdentityService.Core.Interfaces;
using IdentityService.Infrastructure.DomainEvents;
using IdentityService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityService.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
            services.AddScoped<IDomainEventDispatcher>(provider => provider.GetService<DomainEventDispatcher>());

            // DB Seeding
            //services.AddTransient<IDatabaseInitializer, DatabaseInitializer>();

            return services;
        }
    }
}
