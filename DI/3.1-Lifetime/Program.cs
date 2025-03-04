using DisposableServices;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder();
builder.Services.AddSingleton<NumberService>();
builder.Services.AddSingleton<SingletonService>();
builder.Services.AddScoped<ScopedService>();
builder.Services.AddTransient<TransientService>();

using var host = builder.Build();

CreateScope(host);
CreateScope(host);

void CreateScope(IHost host)
{
    using var scope = host.Services.CreateScope();

    var services = scope.ServiceProvider;
    var singletonService1 = services.GetRequiredService<SingletonService>();
    singletonService1.Foo();
    var singletonService2 = services.GetRequiredService<SingletonService>();
    singletonService2.Foo();
    var scopedService1 = services.GetRequiredService<ScopedService>();
    scopedService1.Foo();
    var scopedService2 = services.GetRequiredService<ScopedService>();
    scopedService2.Foo();
    var transientService1 = services.GetRequiredService<TransientService>();
    transientService1.Foo();
    var transientService2 = services.GetRequiredService<TransientService>();
    transientService2.Foo();
    Console.WriteLine("Scope ends...");
    Console.WriteLine();
}
