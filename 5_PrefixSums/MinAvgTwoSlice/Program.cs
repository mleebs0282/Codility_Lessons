using System;
using System.Linq;

namespace MinAvgTwoSlice
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(int[] A)
            {
                int minCount = 0;
                double minimum = 100001.0;

                for (int i = 0; i < A.Length - 1; i++)
                {

                    if (((A[i] + A[i + 1]) / 2.0) < minimum)
                    {
                        minCount = i;
                        minimum = (A[i] + A[i + 1]) / 2.0;

                    }
                    if (i < A.Length - 2)
                    {
                        if (((A[i] + A[i + 1] + A[i + 2]) / 3.0) < minimum)
                        {
                            minCount = i;
                            minimum = (A[i] + A[i + 1] + A[i + 2]) / 3.0;
                        }
                    }
                }

                return minCount;
            }
            Console.WriteLine(solution(new int[] { 4, 2, 2, 5, 1, 5, 8 }));
        }
    }
}
