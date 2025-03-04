namespace DIContainer;

internal class DoubleCalculator(IMath<double> math)
{
    public void Calculate()
    {
        var result = math.Add(123.456, 789.012);
        Console.WriteLine($"Using double calculator, result: {result}");
    }
}
