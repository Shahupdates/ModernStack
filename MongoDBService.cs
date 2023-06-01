using MongoDB.Driver;

public class MongoDbService
{
    private readonly IMongoDatabase _database;

    public MongoDbService()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        _database = client.GetDatabase("myDatabase");
    }
    
    // metod() to perform crud operations to mongoDB collection: insert a document
    public void InsertDocument<T>(string collectionName, T document)
    {
        var collection = _database.GetCollection<T>(collectionName);
        collection.InsertOne(document);
    }
}
