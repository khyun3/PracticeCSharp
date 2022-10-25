namespace CSharp.유형
{
    public struct SPoint
    {
        public double X { get; }
        public double Y { get; }

        public SPoint(double x, double y) => (X, Y) = (x, y);
    }
}