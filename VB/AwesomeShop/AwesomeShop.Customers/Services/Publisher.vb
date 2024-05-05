Imports RabbitMQ.Client
Imports System.Data.Common

Imports System.Text
Public Class Publisher
    Private ReadOnly _connection As IConnection
    Private ReadOnly _channel As IModel
    Private Const Exchange As String = "customers-service"

    Public Sub New()
        Dim connectionFactory As New ConnectionFactory With {
            .HostName = "localhost"
        }

        _connection = connectionFactory.CreateConnection("customers-service-publisher")
        _channel = _connection.CreateModel()
    End Sub

    Public Function PublishMsg(ByVal text As String) As Boolean
        Try
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(text)
            _channel.BasicPublish(Exchange, "customer-created", Nothing, byteArray)
            Return True
        Catch ex As Exception
            Console.WriteLine("Failed to publish message: " & ex.Message)
            Return False
        End Try
    End Function
End Class
