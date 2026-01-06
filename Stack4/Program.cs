using System;
using System.Collections.Generic;
using System.Linq;

internal class SimpleCalculator
{
    private static void Main()
    {
        var tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Stack<int> stack = new Stack<int>();

        // We transform "a + b - c + d" into pushing numbers with sign:
        if (tokens.Length == 0) { Console.WriteLine(0); return; }

        // First token is a number
        stack.Push(int.Parse(tokens[0]));

        for (int i = 1; i < tokens.Length; i += 2)
        {
            var op = tokens[i];
            var num = int.Parse(tokens[i + 1]);
            if (op == "+") stack.Push(num);
            else if (op == "-") stack.Push(-num);
        }

        int result = 0;
        while (stack.Count > 0) result += stack.Pop();
        Console.WriteLine(result);
    }
}