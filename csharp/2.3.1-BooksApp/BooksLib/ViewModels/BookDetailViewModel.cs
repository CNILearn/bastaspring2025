using BooksLib.Services;

using System.Windows.Input;

using TheBestMVVMFrameworkInTown;

namespace BooksLib.ViewModels;

public class BookDetailViewModel : ObservableObject
{
    private readonly IBooksService _booksService;
    private readonly BookStateService _bookStateService;

    public BookDetailViewModel(IBooksService booksService, BookStateService bookStateService)
    {
        _booksService = booksService;
        _bookStateService = bookStateService;

        CreateBookCommand = new DelegateCommand(CreateBook);
        SaveBookCommand = new DelegateCommand(async () => await SaveBookAsync());
    }

    public ICommand CreateBookCommand { get; }
    public ICommand SaveBookCommand { get; }

    public void CreateBook()
    {
        Book = new Book("new book");
    }

    public async Task SaveBookAsync()
    {
        if (Book is null)
        {
            return;
        }
        await _booksService.AddBookAsync(Book);
    }

    private Book? _book;
    public Book? Book
    {
        get => _book;
        set => SetProperty(ref _book, value);
    }
}
