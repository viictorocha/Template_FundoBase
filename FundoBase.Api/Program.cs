using FundoBase.Data;
using FundoBase.Domain;
using FundoBase.Infra;
using FundoBase.Service;

var builder = WebApplication.CreateBuilder(args);

// Injeções de Dependência
builder.Services.AddDomain();
builder.Services.AddData(builder.Configuration);
builder.Services.AddInfra(builder.Configuration);
builder.Services.AddServices();

// Configuração do pipeline HTTP
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

app.Run();
