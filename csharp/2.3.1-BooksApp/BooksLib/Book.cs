using TheBestMVVMFrameworkInTown;

namespace BooksLib;

public class Book(string title, string? publisher = default, int id = 0)
    : ObservableObject
{
    private string _title = title;

    public string Title 
    { 
        get => _title; 
        set => SetProperty(ref _title, value);
    }

    private string? _publisher = publisher;

    public string? Publisher
    {
        get => _publisher; 
        set => SetProperty(ref _publisher, value);
    }


    public int Id { get; set; } = id;

    public override string ToString() => Title;

}
