using CodilityTest.Questions.Arrays;
using CodilityTest.Questions.CountingElements;
using CodilityTest.Questions.Prefix_Sums;
using CodilityTest.Questions.TimeComplexity;
using System;

namespace CodilityTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PassingCars.Solution(new int[] { 0, 1, 0, 1, 1 }));
        }

        public static void Print()
        {
            Console.Write("(");
            var array = MaxCounters.BetterSolution(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    Console.Write(array[i]);
                else
                    Console.Write(array[i] + ", ");
            }

            Console.Write(")");
        }
    }
}
