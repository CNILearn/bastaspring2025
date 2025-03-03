using System.Net.Http.Json;

namespace BooksLib.Services;

public class BooksHttpClient(HttpClient client) : IBooksService
{
    public async Task<Book> AddBookAsync(Book book)
    {
        var response = await client.PostAsJsonAsync("/api/Book", book);
        var returnedBook = await response.Content.ReadFromJsonAsync<Book>() ?? 
            throw new InvalidOperationException("Book not added");
        return returnedBook;
    }

    public async Task<Book?> GetBookByIdAsync(int id)
    {
        var book = await client.GetFromJsonAsync<Book>($"/api/Book/{id}");
        return book;
    }

    public async Task<IEnumerable<Book>> GetBooksAsync()
    {
        var books = await client.GetFromJsonAsync<IEnumerable<Book>>("/api/Book");
        return books ?? [];
    }

    public async Task<bool> UpdateBookAsync(Book book)
    {
        await client.PutAsJsonAsync($"/api/Book/{book.Id}", book);
        return true;
    }
}
