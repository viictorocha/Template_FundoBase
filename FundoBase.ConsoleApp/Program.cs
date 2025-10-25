using FundoBase.ConsoleApp;
using FundoBase.Data;
using FundoBase.Domain;
using FundoBase.Infra;
using FundoBase.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        var configuration = context.Configuration;

        // Camadas de injeção
        services.AddDomain();
        services.AddData(configuration);
        services.AddInfra(configuration);
        services.AddServices();

        // Registrar a classe principal que executará a lógica do console
        services.AddTransient<AppExecutor>();
    })
    .Build();

// Resolve e executa a lógica principal
var app = host.Services.GetRequiredService<AppExecutor>();
await app.RunAsync();
