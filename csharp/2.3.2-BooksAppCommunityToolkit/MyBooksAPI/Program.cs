using BooksLib.Data;
using BooksLib.Services;

using Microsoft.EntityFrameworkCore;

using MyBooksAPI;
var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
builder.Services.AddDbContext<IBooksService, BooksContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BooksContext") ?? throw new InvalidOperationException("Connection string 'BooksContext' not found.")));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};

app.UseHttpsRedirection();

app.MapBookEndpoints();

app.Run();
