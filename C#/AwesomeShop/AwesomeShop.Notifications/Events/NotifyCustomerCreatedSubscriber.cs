using Microsoft.AspNetCore.Connections;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace AwesomeShop.Notifications.Events
{
    public class NotifyCustomerCreatedSubscriber : BackgroundService
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private const string Queue = "notifications-service/customer-created";
        public NotifyCustomerCreatedSubscriber()
        {
            var connectionFactory = new ConnectionFactory
            {
                HostName = "localhost"
            };

            _connection = connectionFactory.CreateConnection("notifications-service-customer-created-consumer");

            _channel = _connection.CreateModel();
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var consumer = new EventingBasicConsumer(_channel);

            consumer.Received += async (sender, eventArgs) =>
            {
                var contentArray = eventArgs.Body.ToArray();
                var message = Encoding.UTF8.GetString(contentArray);

                Console.WriteLine($"Message CustomerCreatedEvent received with {message}");

                _channel.BasicAck(eventArgs.DeliveryTag, false);
            };

            _channel.BasicConsume(Queue, false, consumer);

            return Task.CompletedTask;
        }
    }
}
