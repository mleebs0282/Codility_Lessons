using System;
using System.Linq;

namespace MissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(int[] A)
            {
                // write your code in C# 6.0 with .NET 4.5 (Mono)
                var number = Enumerable.Range(1, 1000000).Except(A);

                return number.FirstOrDefault();
            }

            int[] numbers = new int[] { 1, 3, 6, 4, 1, 2 };

            Console.WriteLine(solution(numbers));
        }
    }
}
