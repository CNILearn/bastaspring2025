using System.Collections.Concurrent;

namespace BooksLib.Services;

public class BooksMemoryService : IBooksService
{
    private readonly ConcurrentDictionary<int, Book> _books = [];
    public BooksMemoryService()
    {
        var books = Enumerable.Range(1, 10)
            .Select(i => new Book($"Book {i}", i % 2 == 0 ? "one" : "two", i))
            .ToList();

        foreach (var book in books)
        {
            _books.AddOrUpdate(book.Id, book, (id, _) => book);
        }
    }

    public Task<IEnumerable<Book>> GetBooksAsync()
    {
        return Task.FromResult<IEnumerable<Book>>(_books.Values);
    }

    public Task<Book?> GetBookByIdAsync(int id)
    {
        if (_books.TryGetValue(id, out var book))
        {
            return Task.FromResult<Book?>(book);
        }
        else
        {
            return Task.FromResult<Book?>(null);
        }
    }

    private readonly Lock _idLock = new();
    public Task<Book> AddBookAsync(Book book)
    {
        //try
        //{
        //    Monitor.Enter(_idLock);
        //}
        //finally
        //{
        //    Monitor.Exit(_idLock);
        //}

        lock (_idLock)
        {
            int nextId = _books.Keys.Max() + 1;
            book.Id = nextId;
            bool added = _books.TryAdd(nextId, book);
            if (!added) throw new InvalidOperationException();
        }
        return Task.FromResult(book);
    }

    public Task<bool> UpdateBookAsync(Book book)
    {
        if (_books.TryGetValue(book.Id, out var existingBook))
        {
            existingBook.Title = book.Title;
            existingBook.Publisher = book.Publisher;
            return Task.FromResult(true);
        }
        return Task.FromResult(false);
    }
}
