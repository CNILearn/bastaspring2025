using System.Numerics;

namespace DIContainer;

internal class Math<T> : IMath<T>
    where T : INumber<T>
{
    public Math()
    {
        Console.WriteLine("constructor");
    }
    public T Add(T a, T b)
    {
        return a + b;
    }

    public T Divide(T a, T b)
    {
        return a / b;
    }

    public T Multiply(T a, T b)
    {
        return a * b;
    }

    public T Subtract(T a, T b)
    {
        return a - b;
    }
}
