namespace Algorithms
{
    internal partial class Program
    {
        class BinaryWords

    {
        static void Main(string[] args)
        {
            string[] names = { "Alice", "Bob", "Charlie", "David", "Emma", "Frank", "Grace" };

            Console.WriteLine("Enter a name to search:");
            string target = Console.ReadLine();

            int index = Array.BinarySearch(names, target);

            if (index >= 0)
            {
                Console.WriteLine("Name found at index: " + index);
            }
            else
            {
                Console.WriteLine("Name not found.");
            }

            Console.ReadLine();
        }
    }

}
}