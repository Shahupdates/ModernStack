public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // MongoDB configuration
        var connectionString = "mongodb://localhost:27017";
        var databaseName = "myDatabase";
        services.AddSingleton(new MongoDbService(connectionString, databaseName));

        // Kafka configuration
        var bootstrapServers = "localhost:9092";
        services.AddSingleton(new KafkaProducerService(bootstrapServers));

        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // ...
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
