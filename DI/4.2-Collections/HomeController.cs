namespace GreetingsSample;

internal class HomeController(IEnumerable<IHelloService> helloServices)
{
    public string Index(string name)
    {
        var service = helloServices.First(helloServices => helloServices.Key == "HelloV2");
        string result = service.Greet(name);
        return result.ToUpper();
    }
}
