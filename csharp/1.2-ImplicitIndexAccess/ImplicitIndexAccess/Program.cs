
//Buffer buffer = new(5)
//{
//    [^5] = 1,
//    [^4] = 2,
//    [^3] = 3,
//    [^2] = 4,
//    [^1] = 5
//};

//buffer.PrintBuffer();


TimerRemaining countdown = new()
{
    Buffer =
    {
        [^1] = 0,
        [^2] = 1,
        [^3] = 2,
        [^4] = 3,
        [^5] = 4,
        [^6] = 5,
        [^7] = 6,
        [^8] = 7,
        [^9] = 8,
        [^10] = 9,
    }
};

for (int i = 0; i < countdown.Buffer.Length; i++)
{
    Console.WriteLine(countdown.Buffer[i]);
    await Task.Delay(500);
}

public class TimerRemaining
{
    public int[] Buffer { get; set; } = new int[10];
}


public class Buffer(int size)
{
    private readonly int[] buffer = new int[size];

    public int this[Index index]
    {
        get => buffer[index];
        set => buffer[index] = value;
    }

    public void PrintBuffer()
    {
        for (int i = 0; i < buffer.Length; i++)
        {
            Console.WriteLine($"Buffer[{i}] = {buffer[i]}");
        }
    }
}