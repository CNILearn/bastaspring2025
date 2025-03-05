using BlazorWithServices.Client.Models;

namespace BlazorWithServices.Client.Services;

public interface IBooksService
{
    Task<IEnumerable<Book>> GetBooksAsync();
    Task<Book?> GetBookAsync(int id);
    Task<Book> AddBookAsync(Book book);
    Task UpdateBookAsync(Book book);
    Task DeleteBookAsync(int id);
}
