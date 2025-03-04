using BooksLib.Services;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BooksLib.ViewModels;

public partial class BookDetailViewModel(IBooksService booksService) : ObservableObject
{
    [RelayCommand]
    public void CreateBook()
    {
        Book = new Book("new book");
    }

    [RelayCommand]
    public async Task SaveBookAsync()
    {
        if (Book is null)
        {
            return;
        }
        await booksService.AddBookAsync(Book);
    }

    //[ObservableProperty]
    //public partial Book? Book { get; set; }

    [ObservableProperty]
    private Book? _book;
}
