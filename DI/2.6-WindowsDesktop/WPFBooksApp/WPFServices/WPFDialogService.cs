using BooksLib.Services;

using System.Windows;

namespace WPFBooksApp.WPFServices;


public class WPFDialogService : IDialogService
{
    public Task ShowAsync(string message)
    {
        MessageBox.Show(message);
        return Task.CompletedTask;
    }
}
