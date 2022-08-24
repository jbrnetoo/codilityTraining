namespace CodilityTest.Questions.Arrays
{
    public static class OddOccurenciesInArray
    {
        public static int Solution(int[] A)
        {
            if (A.Length > 1)
            {
                int xor = A[0];

                for (int i = 1; i < A.Length; i++)
                {
                    xor = xor ^ A[i];
                }

                return xor;
            }
            else
            {
                return A[0];
            }
        }
    }
}
