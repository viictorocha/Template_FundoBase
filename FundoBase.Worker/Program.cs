using FundoBase.Data;
using FundoBase.Domain;
using FundoBase.Infra;
using FundoBase.Service;
using FundoBase.Worker;

var builder = Host.CreateApplicationBuilder(args);

// Inje��es de Depend�ncia
builder.Services.AddDomain();
builder.Services.AddData(builder.Configuration);
builder.Services.AddInfra(builder.Configuration);
builder.Services.AddServices();

builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();