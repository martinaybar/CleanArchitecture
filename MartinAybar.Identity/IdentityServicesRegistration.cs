using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MartinAybar.Identity
{
    public static class IdentityServicesRegistration
    {
        public static void AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(IdentityConstants.ApplicationScheme).AddIdentityCookies();

            //services.AddAuthorizationBuilder(); //TODO Add

            services.AddDbContext<CleanArchitectureIdentityDbContext>(options 
                => options.UseSqlServer(configuration.GetConnectionString("CleanArchitectureIdentityConnectionString")));

            services.AddIdentityCore<ApplicationUser>()
                .AddEntityFrameworkStores<CleanArchitectureIdentityDbContext>();
                //.AddApiEndpoints(); //TODO Add
        }
    }
}
