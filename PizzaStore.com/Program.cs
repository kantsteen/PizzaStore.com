namespace PizzaStore.com
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting PizzaStore!");
            Store s = new Store();
            s.Start();
        }
    }
}
