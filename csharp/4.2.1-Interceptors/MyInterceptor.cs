using System.Runtime.CompilerServices;

namespace Interceptors;
public static class MyInterceptor
{
    [InterceptsLocation(@"D:\cnilearn\bastaspring2025\csharp\4.2.2-Interceptors\Runner.cs", 7, 9)]
    public static void InterceptDotheMagic(int x)
    {
        Console.WriteLine($"Intercepting DotheMagic with {x}");
    }

    [InterceptsLocation(@"D:\cnilearn\bastaspring2025\csharp\4.2.2-Interceptors\Runner.cs", 9, 9)]
    public static void FooMagic(this Runner r)
    {
        Console.WriteLine($"Intercepting Foo");
    }
}
