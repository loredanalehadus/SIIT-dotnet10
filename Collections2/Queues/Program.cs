namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare a queue
            Queue<string> lunchQueue = new Queue<string>();

            lunchQueue.Enqueue("Maria");
            lunchQueue.Enqueue("Gigi");
            lunchQueue.Enqueue("John");
            lunchQueue.Enqueue("Eva");

            // check the first element of the queue
            Console.WriteLine($"First person in line is {lunchQueue.Peek()}");

            Console.WriteLine($"Is Gigi still in queue? {lunchQueue.Contains("Gigi")}");

            // removes all the elements in the queue
            while (lunchQueue.Count > 0)
            {
                var nextInLine = lunchQueue.Dequeue();
                Console.WriteLine(nextInLine);
            }

            //or

            lunchQueue.Clear();

            //Queue<int> intQueue = new Queue<int> { 1, 2, 3 }; // not possible

        }
    }
}
