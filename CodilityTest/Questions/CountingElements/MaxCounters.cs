using System.Linq;

namespace CodilityTest.Questions.CountingElements
{
    public static class MaxCounters
    {
        #region [ First Solution ]
        public static int[] Solution(int N, int[] A)
        {
            int maxElem = A.Max();
            var arrayEsperado = new int[maxElem - 1];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != N + 1)
                    arrayEsperado[A[i] - 1] += 1;
                else
                {
                    maxElem = arrayEsperado.Max();
                    for (int j = 0; j < arrayEsperado.Length; j++)
                    {
                        arrayEsperado[j] = maxElem;
                    }
                }
            }

            return arrayEsperado;
        }
        #endregion

        #region [ Second Solution ]
        public static int[] SecondSolution(int N, int[] A)
        {
            int maxElem = A.Max();
            var arrayEsperado = new int[maxElem - 1];
            return GetCounters(0, arrayEsperado, N, A);
        }

        public static int[] GetCounters(int saveInteration, int[] arrayEsperado, int N, int[] A)
        {
            bool runMaxCounters = false;

            for (int i = saveInteration; i < A.Length; i++)
            {
                if (A[i] != N + 1)
                {
                    arrayEsperado[A[i] - 1] += 1;
                }
                else
                {
                    saveInteration = i + 1;
                    runMaxCounters = true;
                    break;
                }
            }

            if (runMaxCounters)
            {
                int maxElem = arrayEsperado.Max();

                for (int j = 0; j < arrayEsperado.Length; j++)
                {
                    arrayEsperado[j] = maxElem;
                }

                GetCounters(saveInteration, arrayEsperado, N, A);
            }

            return arrayEsperado;
        }
        #endregion

        #region [ Solution 100% ] 
        public static int[] BetterSolution(int N, int[] A)
        {
            int[] arrayEsperado = new int[N];
            int max = 0, globalMax = 0;
            foreach (var item in A)
            {
                if (item > N)
                {
                    globalMax = max;
                }
                else
                {
                    if (arrayEsperado[item - 1] < globalMax)
                    {
                        arrayEsperado[item - 1] = globalMax;
                    }
                    arrayEsperado[item - 1]++;
                    if (max < arrayEsperado[item - 1])
                    {
                        max = arrayEsperado[item - 1];
                    }
                }
            }
            for (int i = 0; i < arrayEsperado.Length; i++)
            {
                if (arrayEsperado[i] < globalMax)
                {
                    arrayEsperado[i] = globalMax;
                }
            }

            return arrayEsperado;
        }
        #endregion
    }
}
