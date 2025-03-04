using BlazorWithServices.Client.Pages;
using BlazorWithServices.Client.Services;
using BlazorWithServices.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BlazorWithServices.Data;
using BlazorWithServices.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddDbContext<IBooksService, BooksContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Books-postgres") ?? throw new InvalidOperationException("Connection string 'BooksContext' not found."));
});
builder.EnrichNpgsqlDbContext<BooksContext>();
//builder.Services.AddDbContext<IBooksService, BooksContext>(options =>
//{
//    var connectionString = builder.Configuration.GetConnectionString("BooksContext") ?? throw new InvalidOperationException("Connection string 'BooksContext' not found.");
//    options.UseSqlServer(connectionString);
//});

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

//builder.Services.AddScoped<IBooksService, BooksService>();

builder.Services.AddSignalR();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorWithServices.Client._Imports).Assembly);

app.MapBookEndpoints();

app.MapHub<ChatHub>("/chat");

app.Run();
