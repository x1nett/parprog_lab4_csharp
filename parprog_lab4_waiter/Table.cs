public class Table
{
    private readonly Fork[] forks;

    public Table()
    {
        forks = new Fork[5];
        for (int i = 0; i < 5; i++)
        {
            forks[i] = new Fork(i);
        }
    }

    public void GetFork(int id)
    {
        forks[id].PickUp();
    }

    public void PutFork(int id)
    {
        forks[id].PutDown();
    }
}
