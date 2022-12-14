namespace CSharp.유형
{
    public class Point3D : Point
    {
        public int Z { get; set; }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override string ToString()
        {
            return base.ToString() + ", Z : " + Z;
        }
    }
}