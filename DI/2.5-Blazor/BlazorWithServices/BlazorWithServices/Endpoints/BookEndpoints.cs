using Microsoft.EntityFrameworkCore;
using BlazorWithServices.Client.Models;
using BlazorWithServices.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using BlazorWithServices.Client.Services;
namespace BlazorWithServices.Endpoints;

public static class BookEndpoints
{
    public static void MapBookEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Book")
            .WithTags(nameof(Book));

        group.MapGet("/CreateDatabase", async Task<Results<InternalServerError, Ok<bool>>> (IBooksService booksService) =>
        {
            if (booksService is BooksContext db)
            {
                var created = await db.CreateDatabaseAsync();
                return TypedResults.Ok(created);
            }
            return TypedResults.InternalServerError();
        })
            .WithName("CreateDatabase")
            .WithOpenApi();

        group.MapGet("/", async (IBooksService booksService) =>
        {
            return await booksService.GetBooksAsync();
        })
        .WithName("GetAllBooks")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Book>, NotFound>> (int id, IBooksService booksService) =>
        {
            var book = await booksService.GetBookAsync(id);
            return book is not null ? TypedResults.Ok(book) : TypedResults.NotFound();
        })
        .WithName("GetBookById")
        .WithOpenApi();

        //group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, Book book, BooksContext db) =>
        //{
        //    var affected = await db.Books
        //        .Where(model => model.Id == id)
        //        .ExecuteUpdateAsync(setters => setters
        //            .SetProperty(m => m.Id, book.Id)
        //            .SetProperty(m => m.Title, book.Title)
        //            .SetProperty(m => m.Publisher, book.Publisher)
        //            );
        //    return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        //})
        //.WithName("UpdateBook")
        //.WithOpenApi();

        group.MapPost("/", async (Book book, IBooksService booksService) =>
        {
            book = await booksService.AddBookAsync(book);

            return TypedResults.Created($"/api/Book/{book.Id}", book);
        })
        .WithName("CreateBook")
        .WithOpenApi();

        //group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, BooksContext db) =>
        //{
        //    var affected = await db.Books
        //        .Where(model => model.Id == id)
        //        .ExecuteDeleteAsync();
        //    return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        //})
        //.WithName("DeleteBook")
        //.WithOpenApi();
    }
}
