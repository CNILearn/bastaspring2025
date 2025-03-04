using BlazorWithServices.Client.Services;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
// builder.Services.AddSingleton<IBooksService, ClientBooksService>();
builder.Services.AddHttpClient<IBooksService, ClientBooksService>(
    client =>  client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
await builder.Build().RunAsync();
