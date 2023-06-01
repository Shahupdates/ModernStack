using MongoDB.Driver;

public class MongoDbService
{
    private readonly IMongoCollection<Person> _Collection;

    public MongoDbService(string connectionString, string databaseName)
    {
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(databaseName);
        _collection = database.GetCollection<Person>("persons");
    }
    
    // metod() to perform crud operations to mongoDB collection: insert a document
    public void InsertDocument<T>(string collectionName, T document)
    {
        var collection = _database.GetCollection<T>(collectionName);
        collection.InsertOne(document);
    }
    
    
    public void InsertPerson(Person person)
    {
        _collection.InsertOne(person);
    }
    
}
