using BooksLib.Services;

using System.Collections.ObjectModel;
using System.Windows.Input;

using TheBestMVVMFrameworkInTown;

namespace BooksLib.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private ObservableCollection<Book> _books = [];
    public IEnumerable<Book> Books => _books;

    private readonly IBooksService _booksService;
 //   private readonly BookStateService _bookStateService;

    public MainWindowViewModel(IBooksService booksService)
    {
        _booksService = booksService;
 //       _bookStateService = bookStateService;
        LoadCommand = new DelegateCommand(async () => await LoadBooksAsync());
    }

    public ICommand LoadCommand { get; private set; }

    public async Task LoadBooksAsync()
    {
        IEnumerable<Book> books = await _booksService.GetBooksAsync();
        foreach (var book in books)
        {
            _books.Add(book);
        }
    }

}
