[ApiController]
[Route("api/persons")]
public class PersonsController : ControllerBase
{
    private readonly MongoDbService _mongoDbService;
    private readonly KafkaProducerService _kafkaProducerService;

    public PersonsController(MongoDbService mongoDbService, KafkaProducerService kafkaProducerService)
    {
        _mongoDbService = mongoDbService;
        _kafkaProducerService = kafkaProducerService;
    }

    [HttpPost]
    public IActionResult CreatePerson(Person person)
    {
        // Store the person in MongoDB
        _mongoDbService.InsertPerson(person);

        // Send a Kafka message
        var message = $"New person created: {person.Name}, {person.Age}";
        _kafkaProducerService.SendMessage("person-topic", message);

        return Ok();
    }
}
