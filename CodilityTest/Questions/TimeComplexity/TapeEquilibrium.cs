using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityTest.Questions.TimeComplexity
{
    public static class TapeEquilibrium
    {
        public static int Solution(int[] A)
        {
            var somaArray = A.Sum();
            var leftSum = A[0];
            var rigthSum = (somaArray - leftSum) - leftSum;
            var rawDiference = leftSum - rigthSum;
            var diference = Math.Abs(rawDiference);
            somaArray -= leftSum;

            for (int P = 2; P <= A.Length; P++)
            {
                leftSum += A[P - 1];
                somaArray -= A[P - 1];

                if (diference > Math.Abs(somaArray - leftSum))
                    diference = Math.Abs(somaArray - leftSum);
            }

            return diference;
        }

        public static int BetterSolution(int[] A)
        {
            // A = { 3, 1, 2, 4, 3 })

            var leftSum = A[0];
            var rigthSum = A.Sum() - leftSum;
            var minDiference = Math.Abs(leftSum - rigthSum);

            for (int P = 1; P < A.Length - 1; P++)
            {
                leftSum += A[P];
                rigthSum -= A[P];
                minDiference = Math.Min(minDiference, Math.Abs(leftSum - rigthSum));
            }

            return minDiference;
        }

        public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> source, int N)
        {
            return source.Skip(Math.Max(0, source.Count() - N));
        }
    }
}
