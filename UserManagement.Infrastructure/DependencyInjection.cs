using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserManagement.Domain.Repository.Interface;
using UserManagement.Infrastructure.Repositories;

namespace UserManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserManagementDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("UserManagementConnection")));

            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
