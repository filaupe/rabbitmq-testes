using AwesomeShop.Sales.Events;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHostedService<OnboardingCustomerCreatedSubscriber>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
