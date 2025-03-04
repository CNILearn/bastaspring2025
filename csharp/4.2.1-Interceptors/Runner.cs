namespace Interceptors;

public class Runner
{
    public void Bar()
    {
        DoTheMagic(42); // this method will be replaced
        DoTheMagic(3); // this method will do the Foo 
        Foo();  
        Foo();
    }

    public static void DoTheMagic(int x)
    {
        Console.WriteLine($"Magic with {x}");
    }

    public void Foo() 
    {
        Console.WriteLine("Foo");
    }
}
