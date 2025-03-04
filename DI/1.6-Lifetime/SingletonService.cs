namespace DisposableServices;

internal class SingletonService : IDisposable
{
    private int _number = 0;    
    public SingletonService(NumberService numberService)
    {
        _number = numberService.GetNumber(nameof(SingletonService));
        Console.WriteLine($"{nameof(SingletonService)} {_number} created");
    }

    private bool _isDisposed = false;
    public void Foo()
    {
        ObjectDisposedException.ThrowIf(_isDisposed, this);

        Console.WriteLine("Foo called");
    }

    public void Dispose()
    {
        Console.WriteLine($"{nameof(SingletonService)} disposed");
        _isDisposed = true;
    }
}
