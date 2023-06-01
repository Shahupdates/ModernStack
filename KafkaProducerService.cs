using Confluent.Kafka;

public class KafkaProducerService
{
    private readonly ProducerConfig _config;

    public KafkaProducerService()
    {
        _config = new ProducerConfig
        {
            BootstrapServers = new ProducerConfig { BootStrapServers = bootstrapServers );

    public void SendMessage(string topic, string message)
    {
        using (var producer = new ProducerBuilder<Null, string>(_config).Build())
        {
            producer.Produce(topic, new Message<Null, string> { Value = message });
            producer.Flush();
        }
    }
}
