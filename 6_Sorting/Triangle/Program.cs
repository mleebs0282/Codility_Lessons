using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(int[] A)
            {
                if (A.Length >= 3)
                {
                    Array.Sort(A);
                    for (int i = 0; i < A.Length; i++)
                    {
                        var P = i; var Q = i + 1; var R = i + 2;
                        if ((A.Length >= 4) && (i >= A.Length - 2)) {
                            R = i - 2;
                            Q = i - 1;
                        } else if(A.Length == 3)
                        {
                            if(i == 1)
                            {
                                R = A.Length - i - 2;
                            } else if (i == 2)
                            {
                                R = i - 2;
                                Q = i - 1;
                            }
                        }
                        if ((A[P] + A[Q] > A[R])
                            && (A[Q] + A[R] > A[P])
                            && (A[R] + A[P] > A[Q]))
                            return 1;
                    }
                }

                return 0;
            }
            //Console.WriteLine(solution(new int[] { 10, 50, 5, 1 }));
            Console.WriteLine(solution(new int[] { 10, 2, 5, 1, 8, 20 }));
        }
    }
}
