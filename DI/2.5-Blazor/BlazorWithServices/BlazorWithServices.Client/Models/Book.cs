namespace BlazorWithServices.Client.Models;

public class Book(int id, string title, string? publisher = default)
{
    public int Id { get; set; } = id;
    public string Title { get; set; } = title;
    public string? Publisher { get; set; } = publisher;
}
