using System.Threading;

public class Fork
{
    private readonly int id;
    private readonly SemaphoreSlim semaphore;

    public Fork(int id)
    {
        this.id = id;
        semaphore = new SemaphoreSlim(1, 1);
    }

    public void PickUp()
    {
        semaphore.Wait();
    }

    public void PutDown()
    {
        semaphore.Release();
    }
}
