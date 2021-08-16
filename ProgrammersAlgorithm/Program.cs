using System;
using System.Linq;

namespace ProgrammersAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num;
            //int[] arr = new int[] { };
            //num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{

            //}

            int[] result = solution(new int[] { 13, 4, 5, 6, 47 });
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }


        public static int[] solution(int[] arr)
        {
            int[] answer = new int[] { };
            int value = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(i == 0)
                {
                    value = arr[i];
                }
                else if(value > arr[i])
                {
                    value = arr[i];
                }
            }

            answer = arr.Where(val => val != value).ToArray();
            if(answer.Length.Equals(0))
            {
                answer = new int[] { -1 };
            }
            return answer;
        }
    }
}
