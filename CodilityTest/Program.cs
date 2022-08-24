using CodilityTest.Questions.CountingElements;
using CodilityTest.Questions.Leader;
using CodilityTest.Questions.StacksQueues;
using System;

namespace CodilityTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dominator.Solution(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 }));
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
