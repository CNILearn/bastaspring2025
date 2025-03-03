using BooksLib.ViewModels;

using Microsoft.Extensions.DependencyInjection;

using System.Windows;

namespace WPFBooksApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;

        if (Application.Current is App app)
        {
            // _booksService = app.MyHost?.Services.GetRequiredService<IBooksService>();
            ViewModel = app.MyHost?.Services.GetRequiredService<MainWindowViewModel>() ?? throw new InvalidOperationException("ViewModel is null");
        }

        if (ViewModel is null) throw new InvalidOperationException();
    }

    public MainWindowViewModel ViewModel { get; private set; }
}