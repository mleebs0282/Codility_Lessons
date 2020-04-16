using System;

namespace ParkPlaceTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            static string solution(int N)
            {
                string phrase = "coding is fun";
                var letters = phrase.Replace(" ", String.Empty).Substring(0, N);
                string distinctLetters = "";

                foreach(var letter in letters)
                {
                    if (distinctLetters.Contains(letter)) {
                        continue;
                    } else
                    {
                        distinctLetters += letter;
                    }
                }

                return distinctLetters;
            }

            Console.WriteLine(solution(7));
        }
    }
}
