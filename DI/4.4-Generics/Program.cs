using DIContainer;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System.Numerics;

var builder = Host.CreateApplicationBuilder();
builder.Services.AddSingleton(typeof(IMath<>), typeof(Math<>));
builder.Services.AddTransient<DoubleCalculator>();

var app = builder.Build();
var calc1 = app.Services.GetRequiredService<IMath<BigInteger>>();
var result1 = calc1.Add(BigInteger.Parse("12345678901234567890"), BigInteger.Parse("12345678901234567890"));
Console.WriteLine(result1);
var calc2 = app.Services.GetRequiredService<IMath<double>>();
var result2 = calc2.Add(123.456, 789.012);
Console.WriteLine(result2);

var dc = app.Services.GetRequiredService<DoubleCalculator>();
dc.Calculate();
