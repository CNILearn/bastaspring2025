using GreetingsSample;

using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new();
services.AddTransient<IHelloService, HelloService>();
services.AddTransient<HomeController>();
using var container = services.BuildServiceProvider();

HomeController controller = container.GetRequiredService<HomeController>();
string result = controller.Index("Matthias");
Console.WriteLine(result);
