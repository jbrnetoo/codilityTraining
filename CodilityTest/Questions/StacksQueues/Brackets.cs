using System.Collections.Generic;
using System.Linq;

namespace CodilityTest.Questions.StacksQueues
{
    public static class Brackets
    {
        public static int Solution(string S)
        {
            // {[()()]} && ([)()]

            Stack<char> stack = new();

            foreach (var c in S)
            {
                switch (c)
                {
                    case ')':
                        if (!stack.Any() || stack.Pop() != '(')
                            return 0;
                        break;
                    case ']':
                        if (!stack.Any() || stack.Pop() != '[')
                            return 0;
                        break;
                    case '}':
                        if (!stack.Any() || stack.Pop() != '{')
                            return 0;
                        break;
                    default:
                        stack.Push(c);
                        break;
                }
            }

            return !stack.Any() ? 1 : 0;
        }
    }
}
