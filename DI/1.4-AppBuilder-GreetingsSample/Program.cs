using GreetingsSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder();
builder.Services.AddTransient<IHelloService, HelloService>();
builder.Services.AddTransient<HomeController>();
using var host = builder.Build();

HomeController controller = host.Services.GetRequiredService<HomeController>();
string result = controller.Index("Stephanie");
Console.WriteLine(result);
