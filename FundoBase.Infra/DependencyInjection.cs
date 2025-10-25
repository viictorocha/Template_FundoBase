using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FundoBase.Infra
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
        {
            // Exemplo: services.AddSingleton<IEmailService, SmtpEmailService>();
            // Exemplo: services.AddScoped<IExternalApiClient, ExternalApiClient>();

            return services;
        }
    }
}
