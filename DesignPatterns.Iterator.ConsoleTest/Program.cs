namespace DesignPatterns.Iterator.ConsoleTest
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var collection = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var iterator = new Implementation.Iterator(collection);
            
            Console.WriteLine("pass 1:");
            while (iterator.MoveNext())
            {
                Console.Write(iterator.Current + " ");
            }

            iterator.Reset();
            
            Console.WriteLine("\npass 2 after reset:");
            while (iterator.MoveNext())
            {
                Console.Write(iterator.Current + " ");
            }
        }
    }
}