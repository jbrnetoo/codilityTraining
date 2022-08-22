using System.Linq;

namespace CodilityTest.Questions.TimeComplexity
{
    // Write a function that, given an array A, returns the value of the missing element.
    public static class PermMissingElem
    {
        public static int Solution(int[] A)
        {
            var sortedList = A.OrderBy(x => x).ToArray();
            int aux = sortedList[0];

            for (int i = 1; i < sortedList.Length; i++)
            {
                if (sortedList[i] != aux + 1)
                    return aux + 1;
                else
                    aux++;
            }
            return sortedList[sortedList.Length - 1] + 1;
        }

        public static int BetterSolution(int[] A)
        {
            long n = A.Length + 1;
            var sumOfAllElements = (n * (1 + n)) / 2;
            var missingElement = sumOfAllElements - A.Select(x => (long)x).Sum();
            return (int)missingElement;
        }
    }
}
