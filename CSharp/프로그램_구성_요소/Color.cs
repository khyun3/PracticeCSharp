namespace CSharp.프로그램_구성_요소
{
    public class Color
    {
        public static readonly Color Black = new Color(0, 0, 0);
        public static readonly Color White = new Color(255, 255, 255);
        public static readonly Color Red = new Color(255, 0, 0);
        public static readonly Color Green = new Color(0, 255, 0);
        public static readonly Color Blue = new Color(0, 0, 255);

        public byte R;
        public byte G;
        public byte B;
        public Color(byte r, byte g, byte b) => (R, G, B) = (r, g, b);
        public override string ToString()
        {
            return "{"+$"r={R}, g={G}, b={B}"+"}";
        }
    }
}