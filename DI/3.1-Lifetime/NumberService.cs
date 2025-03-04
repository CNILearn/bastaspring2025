using System.Collections.Concurrent;

namespace DisposableServices;

internal class NumberService
{
    private ConcurrentDictionary<string, int> _numbers = new();
    public int GetNumber(string key)
    {
        return _numbers.AddOrUpdate(key, 1, (k, v) => v + 1);
    }
}
