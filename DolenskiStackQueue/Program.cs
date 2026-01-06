internal class ReverseNumbersStack
{
    private static void Main()
    {
        // Read a line of integers, push onto Stack and pop them to reverse order.
        var line = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line)) return;

        var tokens = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        Stack<int> stack = new Stack<int>();
        foreach (var t in tokens) stack.Push(int.Parse(t));

        bool first = true;
        while (stack.Count > 0)
        {
            if (!first) Console.Write(" ");
            Console.Write(stack.Pop());
            first = false;
        }
        Console.WriteLine();
    }
}