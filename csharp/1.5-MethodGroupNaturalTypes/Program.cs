var c = new C();
var d = new D();
d.Del(c.M); // .NET 8, this calls DExt.Del. .NET 9, with the change, it calls D.Del - instance methods first!

public class C
{
    public void M()
    {
        Console.WriteLine("C.M");
    }
}

public static class CExt
{
    public static void M(this C c, object o) 
    {
        Console.WriteLine("CExt.M");
    }
}

public class D
{
    public void Del(Delegate d)
    {
        Console.WriteLine("D.Del");
//        d.DynamicInvoke();
        ((Action)d)();
    }
}

public static class DExt
{
    public static void Del(this D d, Action<object> action) 
    {
        Console.WriteLine("DExt.Del");
        action(42);
    }
}
