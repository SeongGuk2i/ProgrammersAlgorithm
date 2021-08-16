using System;

namespace Programmers_Lv2_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            solution(new int[] { 2, 6, 8, 14 });
        }

        public static int solution(int[] arr)
        {
            int answer = 0;
            if(arr.Length > 1)
            {
                answer = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    int gcd = answer;
                    if (answer > arr[i])
                    {
                        gcd = Getgcd(arr[i], answer);
                    }
                    else
                    {
                        gcd = Getgcd(answer, arr[i]);
                    }
                    answer = (answer * arr[i]) / gcd;
                }
            }

            return answer;
        }

        private static int Getgcd(int a, int b)
        {
            return (a % b == 0 ? b : Getgcd(b, a % b));
        }
    }
}
