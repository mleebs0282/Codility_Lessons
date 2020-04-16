using System;
using System.Linq;
using System.Collections.Generic;

namespace FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(int X, int[] A)
            {
                // Don't need to iterate through entire list and add to another, EX: //tempList.AddRange(A.Where(a => !distinctNumbers.All(d => tempList.Contains(d))));
                List<int> distinctNumbers = Enumerable.Range(1, X).ToList();
                //A more accurate representation of distinct numbers than A.Distinct(), Distinct will use any number in the list where intersect only uses 1 to X
                List<int> distinctComparison = A.Intersect(distinctNumbers).ToList();

                if (distinctComparison.Count == X)
                    //Was using distinctComparison.SequenceEqual(distinctNumbers) for predicate
                    return Array.FindIndex(A, r => r.Equals(distinctComparison.Last()));

                return -1;
            }

            Console.WriteLine(solution(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }));
        }
    }
}
