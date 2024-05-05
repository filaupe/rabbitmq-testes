using AwesomeShop.Notifications.Events;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHostedService<NotifyCustomerCreatedSubscriber>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
