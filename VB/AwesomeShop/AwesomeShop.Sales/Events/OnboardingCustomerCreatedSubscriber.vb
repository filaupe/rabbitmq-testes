Imports RabbitMQ.Client
Imports RabbitMQ.Client.Events
Imports System.Text
Imports System.Threading
Imports Microsoft.Extensions.Hosting

Public Class OnboardingCustomerCreatedSubscriber
    Inherits BackgroundService

    Private ReadOnly _connection As IConnection
    Private ReadOnly _channel As IModel
    Private Const Queue As String = "sales-service/customer-created"

    Public Sub New()
        Dim connectionFactory As New ConnectionFactory With {
            .HostName = "localhost"
        }

        _connection = connectionFactory.CreateConnection("sales-service-customer-created-consumer")
        _channel = _connection.CreateModel()
    End Sub

    Protected Overrides Function ExecuteAsync(ByVal stoppingToken As CancellationToken) As Task
        Dim consumer As New EventingBasicConsumer(_channel)

        AddHandler consumer.Received, Async Sub(sender, eventArgs)
                                          Dim contentArray As Byte() = eventArgs.Body.ToArray()
                                          Dim message As String = Encoding.UTF8.GetString(contentArray)

                                          Console.WriteLine($"Message CustomerCreatedEvent received with {message}")

                                          _channel.BasicAck(eventArgs.DeliveryTag, False)
                                      End Sub

        _channel.BasicConsume(Queue, False, consumer)

        Return Task.CompletedTask
    End Function
End Class
