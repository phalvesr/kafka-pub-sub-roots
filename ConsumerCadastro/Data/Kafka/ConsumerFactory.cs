using Confluent.Kafka;

namespace ConsumerCadastro.Data.Kafka;

internal class ConsumerFactory : IConsumerFactory<string, Null>
{
    public IConsumer<string, Null> Consumer
        => new ConsumerBuilder<string, Null>(new ConsumerConfig 
        {
            BootstrapServers = "localhost:9092",
            EnableAutoCommit = false,
            AllowAutoCreateTopics = false,
            GroupId = "",
            ClientId = ""
        })
        .Build();
}

