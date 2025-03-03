using System.Windows.Input;

namespace TheBestMVVMFrameworkInTown;

public class DelegateCommand(Action execute, Func<bool>? canExecute = default) : 
    ICommand
{
    private Action _execute = execute;
    private Func<bool>? _canExecute = canExecute;

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter) => 
        _canExecute is null ? true : _canExecute();

    public void Execute(object? parameter) => 
        _execute();

    public void RaiseCanExecuteChanged() =>
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
}
