using System;
using System.Reflection;
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

        //Feature 'target-typed object creation' is not available. Please use language version 9.0 or greater.
        //private EditBox _editBox = new();
        private EditBox _editBox = new EditBox();
        
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
                    Console.WriteLine("SPoint : { X : " + _sPoint.X + ", Y : " + _sPoint.Y);
                    break;
                case "5": //인터페이스
                    IControl control = _editBox;
                    control.Paint();
                    IDataBound dataBound = _editBox;
                    Console.WriteLine("_editBox -> IDataBound : "+ dataBound.GetType());
                    break;
                case "6"://enum
                    Console.WriteLine(SomeRootVegetable.Turnip);
                    var theYear = Seasons.All;
                    var startingOnEquinox = Seasons.Summer | Seasons.Autumn;
                    Console.WriteLine("theYear : " + theYear);
                    Console.WriteLine("startingOnEquinox : " + startingOnEquinox);
                    Console.WriteLine(Seasons.Spring);
                    break;
                case "7": //Nullable 유형
                    int? optionalInt = default;
                    //Feature 'nullable reference types' is not available. Please use language version 8.0 or greater.
                    //string optionalText = default;
                    Console.WriteLine("Nullable int default value : " + optionalInt);
                    optionalInt = 5;
                    Console.WriteLine("after set value : " + optionalInt);
                    break;
                case "8": //튜플
                    (double Sum, int Count) t2 = (5.1, 3);
                    Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
                    break;
                default:
                    Console.WriteLine(Constants.MENU_IS_NOT_EXIST);
                    break;
            }
        }
    }
}