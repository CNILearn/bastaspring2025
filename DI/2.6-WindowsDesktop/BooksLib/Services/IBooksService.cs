
namespace BooksLib.Services;

public interface IBooksService
{
    Task<Book> AddBookAsync(Book book);
    Task<Book?> GetBookByIdAsync(int id);
    Task<IEnumerable<Book>> GetBooksAsync();
    Task<bool> UpdateBookAsync(Book book);
}