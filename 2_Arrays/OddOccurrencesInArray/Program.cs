using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            static int GetUnpairedElement(int[] A)
            {
                var dict = new Dictionary<int, int>(); // Define dictionary to store value and count
                foreach (var count in A) {
                    if (dict.ContainsKey(count)) {
                        dict[count]++; // Add 1 to count each time it finds a duplicate key in the dictionary
                    } else {
                        dict[count] = 1; // Initialize count to 1
                    }
                }

                return dict.Where(v => v.Value == 1).Select(e => e.Key).FirstOrDefault(); // Get Key where count is 1
            }

            var arr = new int[] { 9, 3, 9, 3, 9, 7, 9 };

            Console.WriteLine(GetUnpairedElement(arr));
        }
    }
}
