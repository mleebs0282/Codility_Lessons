using System;
using System.Linq;

namespace MaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[] solution(int N, int[] A)
            {
                int[] counters = new int[N];
                for(int i = 0; i < A.Length; i++) {
                    if(A[i] <= N) {
                        counters[A[i]-1]++; }
                    if (A[i] == N + 1) {
                        counters = Enumerable.Repeat(counters.Max(), N).ToArray();
                    }
                }
                return counters;
            }
            Console.WriteLine(solution(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }));
        }
    }
}
