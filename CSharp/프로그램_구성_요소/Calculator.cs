namespace CSharp.프로그램_구성_요소
{
    public static class Calculator
    {
        public static void Swap(ref int x, ref int y)
        {
            // int temp = x;
            // x = y;
            // y = temp;
            
            //tuple을 사용하여 swap 코드 refactoring - C# ver 7 이상 
            (x, y) = (y, x);
        }
        
        public static void Divide(int x, int y, out int quotient, out int remainder)
        {
            quotient = x / y;
            remainder = x % y;
        }
    }
}