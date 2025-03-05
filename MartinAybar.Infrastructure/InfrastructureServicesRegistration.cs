using MartinAybar.Application.Contracts.Infrastructure;
using MartinAybar.Application.Models.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace MartinAybar.Infrastructure;

public static class InfrastructureServicesRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<EmailSettings>(options => configuration.GetSection("EmailSettings"));

        services.AddTransient<IEmailService, EmailService>();
        services.AddTransient<ICSVExporterService, CSVExporterService>();

        return services;
    }

}
