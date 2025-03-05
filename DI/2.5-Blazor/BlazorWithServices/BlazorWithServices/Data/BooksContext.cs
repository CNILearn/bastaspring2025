using BlazorWithServices.Client.Models;
using BlazorWithServices.Client.Services;

using Microsoft.EntityFrameworkCore;

namespace BlazorWithServices.Data;

public class BooksContext(DbContextOptions<BooksContext> options) : DbContext(options), IBooksService
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Book> books = [.. Enumerable.Range(1, 10)
            .Select(x => new Book(
                x,
                $"Book {x}",
                $"Publisher {x}"))];

        modelBuilder.Entity<Book>().HasData(books);

//        modelBuilder.Entity<Book>().Property(b => b.Title).HasMaxLength(40);
    }

    public async Task<bool> CreateDatabaseAsync()
    {
        // await Database.EnsureDeletedAsync();
        bool created = await Database.EnsureCreatedAsync();
        return created;
    }

    public DbSet<Book> Books => Set<Book>();

    public async Task<Book> AddBookAsync(Book book)
    {
        Books.Add(book);
        await SaveChangesAsync();
        return book;
    }

    public Task DeleteBookAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Book?> GetBookAsync(int id)
    {
        var book = await Books.FindAsync(id);
        return book;
    }

    public async Task<IEnumerable<Book>> GetBooksAsync()
    {
        var books = await Books.ToListAsync();
        return books;
    }

    public Task UpdateBookAsync(Book book)
    {
        throw new NotImplementedException();
    }
}
