using System;
using System.Collections.Generic;
using System.Linq;


namespace CodilityTest.Questions.CountingElements
{
    public static class MissingInteger
    {
        public static int Solution(int[] A)
        {
            var array = A.Where(x => x > 0).Distinct().OrderBy(x => x).ToArray();

            if (!array.Any())
                return 1;
            else
            {
                int smallestMissing = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (smallestMissing < array[i])
                        break;

                    smallestMissing = array[i] + 1;
                }

                return smallestMissing;
            }
        }
    }
}
