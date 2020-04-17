using System;
using System.Collections.Generic;
using System.Linq;

namespace GenomicRangeQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[] solution(String S, int[] P, int[] Q)
            {
                var dnaArray = S.ToCharArray();
                var dnaNumericalList = new List<int>();
                var queryArray = new int[P.Length];
                int minimum;
                for(int i = 0; i < dnaArray.Length; i++)
                {
                    switch (dnaArray[i])
                    {
                        case 'A':
                            dnaNumericalList.Add(1);
                            break;
                        case 'C':
                            dnaNumericalList.Add(2);
                            break;
                        case 'G':
                            dnaNumericalList.Add(3);
                            break;
                        case 'T':
                            dnaNumericalList.Add(4);
                            break;
                    }
                }

                for (int i = 0; i < P.Length; i++)
                {
                    if (P[i] < Q[i])
                        minimum = dnaNumericalList.GetRange(P[i], Q[i] - P[i] + 1).Min();
                    else
                        minimum = dnaNumericalList[P[i]];

                    queryArray[i] = minimum;
                }

                return queryArray;
            }
            var p = new int[] { 2, 5, 0 };
            var q = new int[] { 4, 5, 6 };
            Console.WriteLine(solution("CAGCCTA", p, q));

            //var p = new int[] { 0, 0, 1 };
            //var q = new int[] { 0, 1, 1 };
            //Console.WriteLine(solution("TC", p, q));
        }
    }
}
