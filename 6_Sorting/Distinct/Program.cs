using System;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(int[] A)
            {
                var distinctIntCount = A.Distinct().Count();
                return distinctIntCount;
            }
            Console.WriteLine(solution(new int[] { 2, 1, 1, 2, 3, 1 }));
        }
    }
}
