using System;

namespace MaxProductOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(int[] A)
            {
                Array.Sort(A);
                int product = 0;
                int moreThanTwoPositive = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
                int lessThanTwoPositive = A[0] * A[1] * A[A.Length - 1];
                if(moreThanTwoPositive >= lessThanTwoPositive)
                    product = moreThanTwoPositive;
                else
                    product = lessThanTwoPositive;

                return product;
            }
            Console.WriteLine(solution(new int[] { -10, -2, -4 }));
        }
    }
}
