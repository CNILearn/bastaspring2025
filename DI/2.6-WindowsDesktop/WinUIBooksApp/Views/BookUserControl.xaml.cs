using BooksLib.ViewModels;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIBooksApp.Views;

public sealed partial class BookUserControl : UserControl
{
    public BookUserControl()
    {
        InitializeComponent();
        if (Application.Current is App app)
        {
            ViewModel = app.MyHost?.Services.GetRequiredService<BookDetailViewModel>() ?? throw new InvalidOperationException("ViewModel is null");
        }

        if (ViewModel is null) throw new InvalidOperationException("ViewModel is null");
    }

    public BookDetailViewModel ViewModel { get; private set; }
}
