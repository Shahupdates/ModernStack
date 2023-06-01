using Confluent.Kafka;

public class KafkaConsumerService
{
    private readonly ConsumerConfig _config;

    public KafkaConsumerService()
    {
        _config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "myConsumerGroup",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };
    }

    public void ConsumeMessages(string topic)
    {
        using (var consumer = new ConsumerBuilder<Ignore, string>(_config).Build())
        {
            consumer.Subscribe(topic);

            while (true)
            {
                var message = consumer.Consume();
                // Process the consumed message
                Console.WriteLine($"Received message: {message.Value}");
            }
        }
    }
}
