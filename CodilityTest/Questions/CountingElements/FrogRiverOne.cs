namespace CodilityTest.Questions.CountingElements
{
    // Write a function that, given a non-empty array A consisting of N integers and integer X,
    // returns the earliest time when the frog can jump to the other side of the river.
    public static class FrogRiverOne
    {
        public static int Solution(int X, int[] A)
        {

            if(A[0] == X)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < A.Length - 1; i++)
                {
                    if (A[i] == X)
                        return i;
                }

                return -1;
            }
        }

        public static int BetterSolution(int X, int[] A)
        {
            bool[] leavesInPosition = new bool[X + 1];

            int occupiedPositions = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int position = A[i];
                if (position <= X && !leavesInPosition[position])
                {
                    leavesInPosition[position] = true;
                    occupiedPositions++;
                }

                if (occupiedPositions == X)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
