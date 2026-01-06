using System;
using System.Collections.Generic;

internal class DecimalToBinaryConverter
{
    private static void Main()
    {
        if (!long.TryParse(Console.ReadLine(), out long n)) return;
        if (n == 0) { Console.WriteLine("0"); return; }
        Stack<int> st = new Stack<int>();
        while (n > 0)
        {
            st.Push((int)(n % 2));
            n /= 2;
        }
        while (st.Count > 0) Console.Write(st.Pop());
        Console.WriteLine();
    }
}