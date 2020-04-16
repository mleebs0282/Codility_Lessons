using System;
using System.Linq;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            static int FindLargestBinaryGap(int N)
            {
                return Convert.ToString(N, 2) // Convert given int to Base 2 (binary) representation to string
                       .Trim('0') // Remove beginning and trailing 0s
                       .Split('1') // Split string into array at 1
                       .Max(e => e.Length); // Get the max length of the string array
            }

            Console.WriteLine(FindLargestBinaryGap(1041));
        }
    }
}
