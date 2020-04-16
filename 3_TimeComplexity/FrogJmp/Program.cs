using System;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(int X, int Y, int D)
            {
                int distance = Y - X;
                //while (distance < Y) {
                //    distance += D;
                //    result++;
                //}

                return (distance % D == 0) ? distance / D : (distance + D) / D;
            }

            Console.WriteLine(solution(10, 85, 30));
        }
    }
}
