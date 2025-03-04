using Microsoft.Extensions.DependencyInjection;

namespace GreetingsSample;

internal class HomeController([FromKeyedServices("HelloV2")]IHelloService helloService)
{
    public string Index(string name)
    {
        string result = helloService.Greet(name);
        return result.ToUpper();
    }
}
