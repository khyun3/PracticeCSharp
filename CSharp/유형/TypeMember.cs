using System;
using CSharp.Properties;

namespace CSharp.유형
{
    public class TypeMember : ISubMenuSelector
    {
        private Point p1;
        private Point p2;

        private Pair<int, string> _pair;
        
        private Point a;
        private Point b;

        private SPoint _sPoint;
        public TypeMember()
        {
            //1
            p1 = new Point(0, 0);
            p2 = new Point(10, 20);
            
            //2
            _pair = new Pair<int, string>(1, "one");
            
            //3
            a = new Point(10, 20);
            b = new Point3D(10, 20, 30);
            
            //4
            _sPoint = new SPoint(10, 20);
        }
        

        public void Select(string subMenu)
        {
            switch (subMenu)
            {
                case "1": //클래스 및 개체
                    Console.WriteLine(p1.ToString());
                    Console.WriteLine(p2.ToString());
                    break;
                case "2": //제네릭
                    Console.WriteLine(_pair.First + ", "+ _pair.Second);
                    break;
                case "3": //기본 클래스
                    Console.WriteLine(a.ToString());
                    Console.WriteLine(b.ToString());
                    break;
                case "4": //구조체
                    Console.WriteLine(_sPoint.X + ", " + _sPoint.Y);
                    break;
                default:
                    Console.WriteLine(Constants.MENU_IS_NOT_EXIST);
                    break;
            }
        }
    }
}