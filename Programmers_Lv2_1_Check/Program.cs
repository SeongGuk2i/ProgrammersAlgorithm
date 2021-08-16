using System;

namespace Programmers_Lv2_1_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            solution(78);
        }

        public static int solution(int n)
        {
            int answer = n + 1;

            while (true)
            {
                string binary = Convert.ToString(n, 2);
                string standardBinary = Convert.ToString(answer, 2);
                if (GetOneCnt(binary) == GetOneCnt(standardBinary))
                {
                    break;
                }
                answer++;
            }

            return answer;
        }

        private static int GetOneCnt(string str)
        {
            char[] pieceNum = str.ToString().ToCharArray();
            int cnt = 0;
            for (int i = 0; i < pieceNum.Length; i++)
            {
                if(pieceNum[i] == '1')
                {
                    cnt = cnt + 1;
                }
            }

            return cnt;
        }
    }
}
