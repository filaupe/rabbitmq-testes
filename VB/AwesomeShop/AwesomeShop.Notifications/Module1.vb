Imports AwesomeShop.Notifications.AwesomeShop.Notifications.Events
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting

Module Module1

    Sub Main(args As String())
        CreateHostBuilder(args).Build().Run()
    End Sub

    Function CreateHostBuilder(args As String()) As IHostBuilder
        Return Host.CreateDefaultBuilder(args) _
            .ConfigureServices(Sub(services)
                                   services.AddHostedService(Of NotifyCustomerCreatedSubscriber)()
                               End Sub)
    End Function

End Module
