using System;
using System.Collections;

namespace Nesting
{
    class Program
    {
        static void Main(string[] args)
        {
            static int solution(string S)
            {
                if (S.Length % 2 != 0) return 0;

                Stack stack = new Stack();

                for (int i = 0; i < S.Length; i++) {
                    var current = S[i].ToString();
                    if (current == "(")
                        stack.Push(current);
                    else {
                        if (stack.Count == 0)
                            return 0;

                        var removed = stack.Pop().ToString();

                        if (removed == "(" && current == ")")
                            continue;
                        else return 0;
                    }
                }
                if (stack.Count == 0) return 1;

                return 0;
            }

            Console.WriteLine(solution("(()(())())"));
        }
    }
}
