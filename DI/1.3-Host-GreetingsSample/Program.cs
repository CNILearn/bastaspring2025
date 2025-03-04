using GreetingsSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.AddTransient<IHelloService, HelloService>();
        services.AddTransient<HomeController>();
    })
    .Build();

HomeController controller = host.Services.GetRequiredService<HomeController>();
string result = controller.Index("Stephanie");
Console.WriteLine(result);
