using System;

namespace CSharp.프로그램_구성_요소
{
    public class Squares
    {
        public static void WriteSquares()
        {
            int i = 0;
            int j;
            while (i < 10)
            {
                j = i * i;
                Console.WriteLine($"{i} x {i} = {j}");
                i++;
            }
        }
    }
}