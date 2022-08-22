namespace CodilityTest.Questions.TimeComplexity
{
    public static class FrogJmp
    {
        // X - frog position
        // Y - position to arrive (>= Y)
        // D - jumps a fixed distance
        // Write a function that, given three integers X, Y and D,
        // returns the minimal number of jumps from position X to a position equal to or greater than Y.
        public static int Solution(int X, int Y, int D)
        {
            if (X < Y)
            {
                int count = 0;
                while(X < Y)
                {
                    X += D;
                    count++;
                }
                return count;
            }
            else
            {
                return 0;
            }
        }

        public static int BetterPerformSolution(int X, int Y, int D)
        {
            decimal result = ((decimal)Y - (decimal)X) / (decimal)D;
            var count = result % 1 == 0 ? (int)result : result + 1;

            return (int)count;
        }
    }
}
