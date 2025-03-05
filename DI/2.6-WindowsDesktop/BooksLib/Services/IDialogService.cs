namespace BooksLib.Services;

/// <summary>
/// demonstrates platform specific dialog service
/// </summary>
public interface IDialogService
{
    Task ShowAsync(string message);
}
