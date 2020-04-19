using System;
using System.Linq;

namespace PassingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(int[] A)
            {
                int eastCars = 0;
                int count = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == 0)
                        eastCars++;
                    else
                        count += eastCars;
                }

                return (count < 1000000000 ? count : -1);
            }
            Console.WriteLine(solution(new int[] { 0, 1, 0, 1, 1 }));
        }
    }
}
