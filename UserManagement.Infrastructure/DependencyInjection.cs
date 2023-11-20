using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace UserManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserManagementDbContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("UserManagementConnection"),
                        b => b.MigrationsAssembly(typeof(UserManagementDbContext).Assembly.FullName)));
            return services;
        }
    }
}
