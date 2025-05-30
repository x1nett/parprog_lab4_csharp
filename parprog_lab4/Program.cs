public class Program
{
    public static void Main()
    {
        Table table = new Table();

        for (int i = 0; i < 5; i++)
        {
            Philosopher philosopher = new Philosopher(i, table);
            philosopher.Start();
        }
    }
}
