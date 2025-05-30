using System;
using System.Threading;

public class Philosopher
{
    private readonly int id;
    private readonly int leftForkId;
    private readonly int rightForkId;
    private readonly Table table;
    private readonly Waiter waiter;
    private readonly Thread thread;

    public Philosopher(int id, Table table, Waiter waiter)
    {
        this.id = id;
        this.table = table;
        this.waiter = waiter;
        rightForkId = id;
        leftForkId = (id + 1) % 5;
        thread = new Thread(Run);
    }

    public void Start()
    {
        thread.Start();
    }

    private void Run()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Філософ {id} думає {i + 1} разів");

            waiter.RequestToEat(id);

            table.GetFork(rightForkId);
            table.GetFork(leftForkId);

            Console.WriteLine($"Філософ {id} їсть {i + 1} разів");

            Thread.Sleep(100);

            table.PutFork(leftForkId);
            table.PutFork(rightForkId);

            waiter.DoneEating(id);
        }
    }
}
