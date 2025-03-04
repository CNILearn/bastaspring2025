namespace DisposableServices;

internal class ScopedService : IDisposable
{
    private int _number = 0;
    public ScopedService(NumberService numberService)
    {
        _number = numberService.GetNumber(nameof(ScopedService));
        Console.WriteLine($"{nameof(ScopedService)} {_number} created");
    }

    private bool _isDisposed = false;
    public void Foo()
    {
        ObjectDisposedException.ThrowIf(_isDisposed, this);
        Console.WriteLine("Foo called");
    }

    public void Dispose()
    {
        Console.WriteLine($"{nameof(ScopedService)} disposed");
        _isDisposed = true;
    }
}
