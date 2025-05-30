using System;
using System.Threading;

public class Philosopher
{
    private readonly int id;
    private readonly int leftForkId;
    private readonly int rightForkId;
    private readonly Table table;
    private readonly Thread thread;

    public Philosopher(int id, Table table)
    {
        this.id = id;
        this.table = table;
        this.rightForkId = id;
        this.leftForkId = (id + 1) % 5;
        this.thread = new Thread(Run);
    }

    public void Start()
    {
        thread.Start();
    }

    private void Run()
    {
        for (int i = 0; i < 10; i++)
        
            Console.WriteLine($"Філософ {id} думає {i + 1} разів");
            if (id % 2 == 0)
        {
            table.GetFork(leftForkId);
            table.GetFork(rightForkId);

            Console.WriteLine($"Філософ {id} їсть {i + 1} разів");
            Thread.Sleep(100);

            table.PutFork(leftForkId);
            table.PutFork(rightForkId);
        }
            else
        {
            table.GetFork(rightForkId);
            table.GetFork(leftForkId);

            Console.WriteLine($"Філософ {id} їсть {i + 1} разів");
            Thread.Sleep(100);

            table.PutFork(rightForkId);
            table.PutFork(leftForkId);
        }
    }
}
