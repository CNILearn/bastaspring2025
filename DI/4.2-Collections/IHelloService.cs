namespace GreetingsSample;

internal interface IHelloService
{
    string Key { get; }
    string Greet(string name);
}