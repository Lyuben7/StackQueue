internal class BrowserHistory
{
    private static void Main()
    {
        Stack<string> backStack = new Stack<string>();
        string current = null;
        while (true)
        {
            string cmd = Console.ReadLine();
            if (cmd == null) break;
            if (cmd == "Home") break;

            if (cmd == "back")
            {
                if (backStack.Count == 0)
                {
                    Console.WriteLine("no previous URLs");
                }
                else
                {
                    current = backStack.Pop();
                    Console.WriteLine(current);
                }
            }
            else
            {
                if (current != null) backStack.Push(current);
                current = cmd;
                Console.WriteLine(current);
            }
        }
    }
}