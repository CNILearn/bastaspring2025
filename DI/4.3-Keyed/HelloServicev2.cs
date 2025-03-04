using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace GreetingsSample;

internal class HelloServiceV2(IOptions<HelloServiceOptions> options, ILogger<HelloService> logger) : IHelloService
{
    public string Key => "HelloV2";

    public string Greet(string name)
    {
        string from = options.Value.From ?? "unknown";
        logger.LogInformation("Greet invoked with {name} from {from}", name, from);

        return $"Guezi, {name}, greetings from {from}!";
    }
}
