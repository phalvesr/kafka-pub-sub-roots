using Confluent.Kafka;
using ConsumerCadastro;
using ConsumerCadastro.Data;
using ConsumerCadastro.Data.Kafka;
using ConsumerCadastro.Data.Repositories;
using Dapper;
using Microsoft.Data.Sqlite;
using System.Data;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddSingleton<IConsumerFactory<string, Null>, ConsumerFactory>();
        services.AddTransient<IClientRepository, ClientRepository>();

        var dbLocation = Path.Combine(Directory.GetCurrentDirectory(), "cadastro.db");
        services.AddScoped<IDbConnection>(x => 
            new SqliteConnection(@"Data Source=C:\Users\Pedro\Desktop\avro\cadastro.db")
        );
    })
    .Build();

await host.RunAsync();
