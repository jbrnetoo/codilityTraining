namespace CodilityTest.Questions.Prefix_Sums
{
    public static class PassingCars
    {
        public static int Solution(int[] A)
        {
            int count = 0;
            int multiply = 0;
            foreach (int car in A)
            {
                if (car == 0)
                {
                    multiply = multiply + 1;
                }
                if (multiply > 0)
                {
                    if (car == 1)
                    {
                        count = count + multiply;
                        if (count > 1000000000)
                        {
                            return -1;
                        }
                    }
                }
            }
            return count;

        }
    }
}
