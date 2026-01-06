using System;
using System.Collections.Generic;

internal class PrinterQueue
{
    private static void Main()
    {
        Queue<string> queue = new Queue<string>();
        string line;
        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            if (line == "print")
            {
                if (queue.Count == 0) { /* print nothing? samples print nothing for empty print */ }
                else
                {
                    while (queue.Count > 0) Console.WriteLine(queue.Dequeue());
                }
                break;
            }
            else if (line == "cancel")
            {
                if (queue.Count == 0) Console.WriteLine("Standby");
                else
                {
                    Console.WriteLine("Canceled " + queue.Dequeue());
                }
            }
            else
            {
                queue.Enqueue(line);
            }
        }
    }
}