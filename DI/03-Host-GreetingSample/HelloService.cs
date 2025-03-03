namespace GreetingsSample;

internal class HelloService : IHelloService
{
    public string Greet(string name) => $"Hello, {name}!";
}
