using MongoDB.Driver;

public class MongoDbService
{
    private readonly IMongoDatabase _database;

    public MongoDbService()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        _database = client.GetDatabase("myDatabase");
    }
}
