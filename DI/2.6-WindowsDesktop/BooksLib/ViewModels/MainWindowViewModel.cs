using BooksLib.Services;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using System.Collections.ObjectModel;

namespace BooksLib.ViewModels;

public partial class MainWindowViewModel(IBooksService booksService, IDialogService dialogService) : ObservableObject
{
    private readonly ObservableCollection<Book> _books = [];
    public IEnumerable<Book> Books => _books;

    [RelayCommand]
    public async Task LoadBooksAsync()
    {
        IEnumerable<Book> books = await booksService.GetBooksAsync();
        foreach (var book in books)
        {
            _books.Add(book);
        }
    }

    [RelayCommand]
    public async Task ShowDialogAsync()
    {
        await dialogService.ShowAsync("Hello from the dialog service");
    }
}
