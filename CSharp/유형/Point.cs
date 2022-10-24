namespace CSharp.유형
{
    public class Point
    {
        private int X { get; }
        private int Y { get; }

        /*
         * 람다를 활용하여
         * public Point(int x, int y) => (X,Y) = (x,y);
         * 와 같이 작성 가능
         */ 
        public Point(int x, int y) 
        {
            X = x;
            Y = y;
        }
    }
}