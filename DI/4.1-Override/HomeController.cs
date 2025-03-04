namespace GreetingsSample;

internal class HomeController(IHelloService helloService)
{
    public string Index(string name)
    {
        string result = helloService.Greet(name);
        return result.ToUpper();
    }
}
