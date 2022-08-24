using System.Collections.Generic;

namespace CodilityTest.Questions.Prefix_Sums
{
    public static class CountDiv
    {
        public static int Solution(int A, int B, int K)
        {
            if (A == B && A % K == 0)
                return 1;

            var array = new List<int>();
            int runRanged = A;
            while (runRanged <= B)
            {
                if (runRanged % K == 0)
                    array.Add(runRanged);

                runRanged++;
            }

            return array.Count;
        }

        public static int BetterSolution(int A, int B, int K)
        {
            return (B / K) - (A / K) + (A % K == 0 ? 1 : 0);
        }
    }
}
