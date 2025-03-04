using BlazorWithServices.Client.Models;

namespace BlazorWithServices.Client.Services;

public class BooksService : IBooksService
{
    private List<Book> _books;
    public BooksService()
    {
        _books = [.. Enumerable.Range(1, 10)
            .Select(x => new Book(
                x,
                $"Book {x}",
                $"Publisher {x}"))];
    }

    public Task<Book> AddBookAsync(Book book)
    {
        book.Id = _books.Max(b => b.Id) + 1;
        _books.Add(book);
        return Task.FromResult(book);
    }

    public Task DeleteBookAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Book?> GetBookAsync(int id)
    {
       var book =  _books.SingleOrDefault(b => b.Id == id);
        return Task.FromResult(book);
    }

    public Task<IEnumerable<Book>> GetBooksAsync()
    {
        IEnumerable<Book>? books = _books;
        return Task.FromResult(books);
    }

    public Task UpdateBookAsync(Book book)
    {
        throw new NotImplementedException();
    }
}
