namespace DisposableServices;

internal class TransientService : IDisposable
{
    private int _number = 0;
    public TransientService(NumberService numberService)
    {
        _number = numberService.GetNumber(nameof(TransientService));
        Console.WriteLine($"{nameof(TransientService)} {_number} created");
    }

    private bool _isDisposed = false;
    public void Foo()
    {
        ObjectDisposedException.ThrowIf(_isDisposed, this);

        Console.WriteLine("Foo called");
    }

    public void Dispose()
    {
        Console.WriteLine($"{nameof(TransientService)} disposed");
        _isDisposed = true;
    }
}
