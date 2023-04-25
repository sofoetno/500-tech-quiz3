using System;

namespace Problem2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}