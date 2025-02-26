
object l2 = new();
Lock l1 = new();

for (int i = 0; i < 10; i++)
{
    int j = i;
    Task t1 = Task.Run(() =>
    {
        lock (l1)
        {
            Console.WriteLine($"{j}: A.");
            Thread.Sleep(1000);
            Console.WriteLine($"{j}: B.");
        }

        using (l1.EnterScope())
        {
            Console.WriteLine($"{j}: C.");
            Thread.Sleep(1000);
            Console.WriteLine($"{j}: D.");
        }

        //lock (l2)
        //{
        //    Console.WriteLine($"{j}: E.");
        //    Thread.Sleep(1000);
        //    Console.WriteLine($"{j}: F.");
        //}

        //Monitor.Enter(l2);
        //Console.WriteLine($"{j}: C.");
        //Thread.Sleep(1000);
        //Console.WriteLine($"{j}: D.");
        //Monitor.Exit(l2);
    });
}

Console.ReadLine();
