Imports RabbitMQ.Client
Imports RabbitMQ.Client.Events
Imports System.Text
Imports System.Threading
Imports Microsoft.Extensions.Hosting

Namespace AwesomeShop.Notifications.Events
    Public Class NotifyCustomerCreatedSubscriber
        Inherits BackgroundService
        Private ReadOnly _connection As IConnection
        Private ReadOnly _channel As IModel
        Private Const Queue As String = "notifications-service/customer-created"

        Public Sub New()
            Dim connectionFactory = New ConnectionFactory() With {
                .HostName = "localhost"
            }

            _connection = connectionFactory.CreateConnection("notifications-service-customer-created-consumer")
            _channel = _connection.CreateModel()
        End Sub

        Protected Overrides Function ExecuteAsync(stoppingToken As CancellationToken) As Task
            Dim consumer = New EventingBasicConsumer(_channel)

            AddHandler consumer.Received, Sub(sender, eventArgs)
                                              Dim contentArray = eventArgs.Body.ToArray()
                                              Dim message = Encoding.UTF8.GetString(contentArray)

                                              Console.WriteLine($"Message CustomerCreatedEvent received with {message}")

                                              _channel.BasicAck(eventArgs.DeliveryTag, False)
                                          End Sub

            _channel.BasicConsume(Queue, False, consumer)

            Return Task.CompletedTask
        End Function
    End Class
End Namespace
