using System;

namespace Programmers_test1
{
    class Program
    {
        static void Main(string[] args)
        {
            solution(new int[] { 1, 2, 3, 4 }, new int[] { -3, -1, 0, 2 });
        }

        public static int solution(int[] a, int[] b)
        {
            int answer = 0;
            if(a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    answer = answer + (a[i] * b[i]);
                }
            }

            return answer;
        }
    }
}
