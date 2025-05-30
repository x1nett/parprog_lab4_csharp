using System;
using System.Threading;

public class Waiter
{
    private readonly SemaphoreSlim semaphore;

    public Waiter(int maxEatingPhilosophers)
    {
        semaphore = new SemaphoreSlim(maxEatingPhilosophers, maxEatingPhilosophers);
    }

    public void RequestToEat(int philosopherId)
    {
        Console.WriteLine($"Філософ {philosopherId} просить дозволу поїсти.");
        semaphore.Wait();
        Console.WriteLine($"Філософ {philosopherId} отримав дозвіл поїстt.");
    }

    public void DoneEating(int philosopherId)
    {
        Console.WriteLine($"Філософ {philosopherId} поїв.");
        semaphore.Release();
    }
}
