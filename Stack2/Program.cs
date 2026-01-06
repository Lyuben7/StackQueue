internal class BasicStackOperations
{
    private static void Main()
    {
        var line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(line[0]), s = int.Parse(line[1]), x = int.Parse(line[2]);

        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < Math.Min(n, numbers.Length); i++) stack.Push(numbers[i]);

        for (int i = 0; i < s && stack.Count > 0; i++) stack.Pop();

        if (stack.Count == 0) { Console.WriteLine(0); return; }
        if (stack.Contains(x)) { Console.WriteLine("true"); return; }
        Console.WriteLine(stack.Min());
    }
}