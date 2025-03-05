using MyWindowsService;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddWindowsService();
builder.Services.AddSystemd();

var host = builder.Build();
host.Run();
