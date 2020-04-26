using System;
using System.Collections.Generic;

namespace Fish
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(int[] A, int[] B)
            {
                int count = 0;
                int liveFish = 0;
                var stack = new Stack<int>();

                for (int i = 0; i < A.Length; i++) {
                    if (B[i] == 0) {
                        while (stack.Count > 0 && A[i] > stack.Peek())
                            stack.Pop();

                        if (stack.Count == 0)
                            count++;
                    } else if (B[i] == 1)
                        stack.Push(A[i]);
                }
                liveFish = stack.Count + count;

                return liveFish;
            }
            var fishSize = new int[] { 4, 3, 2, 1, 5 };
            var stream = new int[] { 0, 1, 0, 0, 0 };
            Console.WriteLine(solution(fishSize, stream));
        }
    }
}
