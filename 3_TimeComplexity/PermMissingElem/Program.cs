using System;
using System.Linq;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(int[] A)
            {
                return Enumerable.Range(1, A.Length + 1).Except(A).FirstOrDefault(); //Gets missing values from A (array) based on range
                // Enumerable.Range(1, A.Length + 1).Except(A.Select(a => a.Property)); // Use Select if you need a class property from an object such as a List/IEnumerable
            }
            Console.WriteLine(solution(new int[] { 2, 3, 1, 5 }));
        }
    }
}
