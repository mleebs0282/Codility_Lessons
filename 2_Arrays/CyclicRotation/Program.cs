using System;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[] MoveNumbers(int[] A, int K)
            {
                int[] newArray = new int[A.Length];
                //int diff = K % A.Length;
                for (var i = 0; i < A.Length; i++)
                {
                    int index = (i + K) % A.Length;
                    newArray[index] = A[i];
                }

                //Array.Copy(A, 0, newArray, diff, A.Length - diff);
                //Array.Copy(A, A.Length - diff, newArray, 0, diff);

                return newArray;
            }
            var arr = new int[] { 3, 8, 9, 7, 6 };

            Console.WriteLine(MoveNumbers(arr, 3));
        }
    }
}
