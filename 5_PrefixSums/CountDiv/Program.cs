using System;
using System.Linq;

namespace CountDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(int A, int B, int K)
            {
                int endPoint = B - A + 1;
                int[] counter = Enumerable.Range(A, endPoint).ToArray();
                int divisibilityCount = 0;
                for(int i = 0; i < counter.Length; i++) {
                    if(counter[i] % K == 0)
                        divisibilityCount++;
                }

                return divisibilityCount;
                //int firstDivisible = A % K == 0 ? 1 : 0;
                //return (B/K) - (A/K) + firstDivisible;
            }
            Console.WriteLine(solution(6, 11, 2));
        }
    }
}
