using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace AwesomeShop.Customers.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private const string Exchange = "customers-service";

        public CustomersController()
        {
            var connectionFactory = new ConnectionFactory
            {
                HostName = "localhost"
            };

            _connection = connectionFactory.CreateConnection("customers-service-publisher");

            _channel = _connection.CreateModel();
        }

        [HttpPost]
        public IActionResult Post(string text)
        {
            var payload = JsonConvert.SerializeObject(text);
            var byteArray = Encoding.UTF8.GetBytes(payload);

            Console.WriteLine("CustomerCreatedEvent Published");

            _channel.BasicPublish(Exchange, "customer-created", null, byteArray);

            return NoContent();
        }
    }
}
