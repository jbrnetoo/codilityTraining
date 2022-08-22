
using System.Linq;

namespace CodilityTest.Questions
{
    public static class Q01
    {
        public static int Solution(int[] A)
        {
            var positives = A.Where(x => x > 0).Distinct().OrderBy(x => x).ToArray();
            if (positives.Count() == 0) return 1;
            int prev = 0;
            for (int i = 0; i < positives.Count(); i++)
            {
                if (positives[i] != prev + 1)
                {
                    return prev + 1;
                }
                prev = positives[i];
            }
            return positives.Last() + 1;
        }
    }
}
