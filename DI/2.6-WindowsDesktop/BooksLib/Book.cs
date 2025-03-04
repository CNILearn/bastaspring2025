using CommunityToolkit.Mvvm.ComponentModel;

namespace BooksLib;

public partial class Book(string title, string? publisher = default, int id = 0)
    : ObservableObject
{
    [ObservableProperty]
    public partial string Title { get; set; } = title;

    [ObservableProperty]
    public partial string? Publisher { get; set; } = publisher;

    public int Id { get; set; } = id;

    public override string ToString() => Title;

}
