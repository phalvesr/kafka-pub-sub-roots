using Confluent.Kafka;

namespace ConsumerCadastro.Data
{
    internal interface IConsumerFactory<TKey, TValue>
    {
        IConsumer<TKey, TValue> Consumer { get; }
    }
}
