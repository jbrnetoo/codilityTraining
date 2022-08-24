using System;
using System.Linq;

namespace CodilityTest.Questions.Leader
{
    public static class Dominator
    {
        public static int Solution(int[] A)
        {
            int dominator = A.Length / 2 + 1;

            var possibleDominator = A
                .GroupBy(x => x)
                .Select(x => new { Element = x.Key, Count = x.Count() })
                .FirstOrDefault(x => x.Count >= dominator);

            if (possibleDominator != null)
                return Array.IndexOf(A, possibleDominator.Element);

            return -1;
        }
    }
}
