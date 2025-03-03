using BooksLib;

using Microsoft.EntityFrameworkCore;

namespace MyBooksAPI.Data;

public class BooksContext(DbContextOptions<BooksContext> options) : 
    DbContext(options), IBooksService
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var books = Enumerable.Range(1, 50)
            .Select(i => new Book($"Book {i}", i % 2 == 0 ? "one" : "two", i))
            .ToList();
        modelBuilder.Entity<Book>().HasData(books);
    }

    public async Task<Book> AddBookAsync(Book book)
    {
        Books.Add(book);
        await SaveChangesAsync();
        return book;
    }

    public async Task<Book?> GetBookByIdAsync(int id)
    {
        var book = await Books.FirstOrDefaultAsync(b => b.Id == id);
        return book;
    }

    public async Task<IEnumerable<Book>> GetBooksAsync()
    {
        var books = await Books.ToListAsync();
        return books;
    }

    public async Task<bool> UpdateBookAsync(Book book)
    {
        Books.Update(book);
        return await SaveChangesAsync() > 0;
    }

    public DbSet<Book> Books => Set<Book>();
}
