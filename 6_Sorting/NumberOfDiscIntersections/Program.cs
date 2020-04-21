using System;

namespace NumberOfDiscIntersections
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(int[] A)
            {
                int count = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (i + A[i] >= j - A[j]) count++;
                    }
                }

                return (count > 10000000) ? -1 : count;
            }
            Console.WriteLine(solution(new int[] { 1, 5, 2, 1, 4, 0 }));
        }
    }
}
