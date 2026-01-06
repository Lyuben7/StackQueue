using System;
using System.Collections.Generic;

internal class MatchingBrackets
{
    private static void Main()
    {
        // Read input string and print all substrings enclosed in matching brackets.
        string input = Console.ReadLine();
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(') stack.Push(i);
            else if (input[i] == ')')
            {
                int start = stack.Pop();
                Console.WriteLine(input.Substring(start, i - start + 1));
            }
        }
    }
}