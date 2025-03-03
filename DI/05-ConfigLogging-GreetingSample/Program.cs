using GreetingsSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder();
builder.Services.AddTransient<IHelloService, HelloService>();
builder.Services.AddTransient<HomeController>();
builder.Services.Configure<HelloServiceOptions>(builder.Configuration.GetSection("HelloService"));
using var host = builder.Build();

HomeController controller = host.Services.GetRequiredService<HomeController>();
string result = controller.Index("Angela");
Console.WriteLine(result);
