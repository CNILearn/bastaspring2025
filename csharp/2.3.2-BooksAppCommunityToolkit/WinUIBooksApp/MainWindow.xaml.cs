using BooksLib.ViewModels;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;

using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIBooksApp;

/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();


        if (Application.Current is App app)
        {
            ViewModel = app.MyHost?.Services.GetRequiredService<MainWindowViewModel>() ?? throw new InvalidOperationException("ViewModel is null");
        }

        if (ViewModel is null) throw new InvalidOperationException("ViewModel is null");
    }

    public MainWindowViewModel ViewModel { get; private set; }
}
