using TheBestMVVMFrameworkInTown;

namespace BooksLib.Services;

public class BookStateService : ObservableObject
{
    private Book? _currentBook;
    public Book? CurrentBook
    {
        get => _currentBook;
        set => SetProperty(ref _currentBook, value);
    }
}
