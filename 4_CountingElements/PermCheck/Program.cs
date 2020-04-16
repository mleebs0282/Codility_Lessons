using System;
using System.Linq;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(int[] A)
            {
                int isPermutation = 0;
                int[] listExpected = Enumerable.Range(A.Min(), A.Max()).ToArray();
                int[] listComparison = A.Intersect(listExpected).ToArray();
                Array.Sort(listComparison);
                if(listComparison.SequenceEqual(listExpected) && listComparison.Length == A.Length)
                {
                    isPermutation = 1;
                }

                return isPermutation;
            }
            Console.WriteLine(solution(new int[] { 1, 3, 4, 2 }));
        }
    }
}
