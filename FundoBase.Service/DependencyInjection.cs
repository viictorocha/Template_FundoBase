using Microsoft.Extensions.DependencyInjection;

namespace FundoBase.Service
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // Exemplo: services.AddScoped<IClienteService, ClienteService>();
            return services;
        }
    }
}
