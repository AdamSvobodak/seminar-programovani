namespace _15_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < 100; i++)
            {
                a++;
                b = a + b;
            }
            Console.WriteLine("součet čísel 1 - 100 je: " + b);
        }
    }
}
