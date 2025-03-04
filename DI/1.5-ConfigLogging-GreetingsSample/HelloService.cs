using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace GreetingsSample;

internal class HelloService(IOptions<HelloServiceOptions> options, ILogger<HelloService> logger) : IHelloService
{
    public string Greet(string name)
    {
        string from = options.Value.From ?? "unknown";
        logger.LogInformation("Greet invoked with {name} from {from}", name, from);
        logger.LogTrace("Trace message");
        return $"Hello, {name}, greetings from {from}";
    }
}

public class HelloServiceOptions
{
    public string? From { get; set; }
}
