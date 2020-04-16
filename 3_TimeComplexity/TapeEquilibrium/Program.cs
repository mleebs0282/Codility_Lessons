using System;
using System.Collections.Generic;
using System.Linq;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(int[] A)
            {
                int count = 0;
                int total = A.Sum();
                List<int> result = new List<int>();
                foreach (int i in A)
                {
                    count += i;
                    result.Add(Math.Abs((total - count) - count));
                }
                return result.Min();
            }

            Console.WriteLine(solution(new int[] { 3, 1, 2, 4, 3 }));
        }
    }
}
