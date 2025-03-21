﻿using BooksLib;
using BooksLib.Services;
using BooksLib.ViewModels;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml;

using WinUIBooksApp.WinUIServices;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIBooksApp;

/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// </summary>
public partial class App : Application
{
    /// <summary>
    /// Initializes the singleton application object.  This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App() => InitializeComponent();

    /// <summary>
    /// Invoked when the application is launched.
    /// </summary>
    /// <param name="args">Details about the launch request and process.</param>
    protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
    {
        var builder = Host.CreateApplicationBuilder();
        // builder.Services.AddSingleton<IBooksService, BooksMemoryService>();
        builder.Services.AddHttpClient<IBooksService, BooksHttpClient>(client =>
        {
            client.BaseAddress = new Uri("https://localhost:7065");
        });
        builder.Services.AddScoped<MainWindowViewModel>();
        builder.Services.AddScoped<BookDetailViewModel>();
        builder.Services.AddSingleton<BookStateService>();
        builder.Services.AddTransient<IDialogService, WinUIDialogService>();
        builder.Services.AddSingleton<DialogWindowService>();
        MyHost = builder.Build();

        _window = new MainWindow();
        _window.Activate();
    }

    private Window? _window;
    public Window? MainWindow => _window;
    public IHost? MyHost { get; private set; }
}
