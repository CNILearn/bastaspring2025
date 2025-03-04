using BlazorWithServices.Client.Models;

using System.Net.Http.Json;

namespace BlazorWithServices.Client.Services;

public class ClientBooksService(HttpClient httpClient) : IBooksService
{
    public async Task<Book> AddBookAsync(Book book)
    {
        var response = await httpClient.PostAsJsonAsync("/api/Book", book);
        var returnedBook = await response.Content.ReadFromJsonAsync<Book>();
        return returnedBook ?? throw new InvalidOperationException();
    }

    public Task DeleteBookAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Book?> GetBookAsync(int id)
    {
        var book = await httpClient.GetFromJsonAsync<Book>($"/api/Book/{id}");
        return book;
    }

    public async Task<IEnumerable<Book>> GetBooksAsync()
    {
        var response = await httpClient.GetAsync("/api/Book");
        response.EnsureSuccessStatusCode();

        var books = await httpClient.GetFromJsonAsync<IEnumerable<Book>>("/api/Book");
        return books ?? Enumerable.Empty<Book>();
    }

    public Task UpdateBookAsync(Book book)
    {
        throw new NotImplementedException();
    }
}
