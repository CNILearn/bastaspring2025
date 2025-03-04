using BooksLib.Services;
using BooksLib.ViewModels;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System.Windows;

using WPFBooksApp.WPFServices;

namespace WPFBooksApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    override protected void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var builder = Host.CreateApplicationBuilder();
        builder.Services.AddSingleton<IBooksService, BooksMemoryService>();
        builder.Services.AddScoped<MainWindowViewModel>();
        builder.Services.AddTransient<IDialogService, WPFDialogService>();
        MyHost = builder.Build();
    }

    public IHost? MyHost { get; private set; } 
}
