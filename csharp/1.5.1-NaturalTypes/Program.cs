using System;

Func<int, int, int> add = Add;
// var add = Add;  // natural type

// Delegate d1 = Add;
// var x = d1.DynamicInvoke(2, 3); // Output: 5

Console.WriteLine(add(2, 3)); // Output: 5

Console.WriteLine(PerformOperation(2, 3, Add)); // Output: 5

static int Add(int x, int y)
{
    return x + y;
}

static int PerformOperation(int x, int y, Func<int, int, int> operation)
{
    return operation(x, y);
}
