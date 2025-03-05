using BooksLib.Services;

using Microsoft.UI.Xaml.Controls;

namespace WinUIBooksApp.WinUIServices;

internal class WinUIDialogService(DialogWindowService dialogWindowService) : IDialogService
{
    public async Task ShowAsync(string message)
    {
        ContentDialog dialog = new()
        {
            Title = "Notification",
            Content = message,
            XamlRoot = dialogWindowService.XamlRoot,
            CloseButtonText = "Ok"
        };

        await dialog.ShowAsync();
    }
}
