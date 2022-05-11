using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProducerCadastro.Converters;
using ProducerCadastro.Services;
using ProducerCadastro.Services.Interfaces;
using Serilog;
using System.Reflection;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Logger
var logger = new LoggerConfiguration()
                .WriteTo.Console()
                .MinimumLevel.Information()
                .CreateLogger();

builder.Services.AddSingleton<ILogger>(logger);

// Mapper
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddControllers();
builder.Services.Configure<JsonOptions>(opt =>
{
    opt.JsonSerializerOptions.PropertyNamingPolicy = new SnakeCaseNamingPolicy();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Services
builder.Services.AddTransient<IClientService, ClientService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
