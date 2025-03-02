
// (text, out result ) => int.TryParse(text, out result);

TryParse<int> tryParseInt = (text, out result) => int.TryParse(text, out result);

Console.WriteLine("enter a number");
string input = Console.ReadLine() ?? string.Empty;

if (tryParseInt(input, out int number))
{
    Console.WriteLine($"You entered the number {number}");
}
else
{
    Console.WriteLine("You did not enter a number");
}

delegate bool TryParse<T>(string s, out T result);
