public class Program
{
    public static void Main()
    {
        Table table = new Table();
        Waiter waiter = new Waiter(2); // дозволяємо одночасно 2 філософам їсти

        for (int i = 0; i < 5; i++)
        {
            Philosopher philosopher = new Philosopher(i, table, waiter);
            philosopher.Start();
        }
    }
}
