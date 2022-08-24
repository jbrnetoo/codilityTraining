using System.Collections.Generic;
using System.Linq;

namespace CodilityTest.Questions.StacksQueues
{
    public static class Nesting
    {
        public static int Solution(string S)
        {
            if (string.IsNullOrEmpty(S))
                return 1;

            Stack<char> stack = new();

            foreach (var item in S)
            {
                switch (item)
                {
                    case ')':
                        if (!stack.Any() || !stack.Pop().Equals('('))
                            return 0;
                        break;
                    default:
                        stack.Push(item);
                        break;
                }
            }

            return !stack.Any() ? 1 : 0;
        }
    }
}
