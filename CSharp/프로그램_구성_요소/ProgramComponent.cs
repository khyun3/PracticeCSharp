using System;
using System.Collections.Generic;
using System.Xml;
using CSharp.Properties;

namespace CSharp.프로그램_구성_요소
{
    public class ProgramComponent : ISubMenuSelector
    {
        public void Select(string subMenu)
        {
            var brown = new Color(165, 42, 42);
            var navy = new Color(0, 0, 80);
            var a = 1;
            var b = 2;
            switch (subMenu)
            {
                case "1": //필드
                    Console.WriteLine("정적으로 선언된 색상 : red : " + Color.Red + ", hashCode : " + Color.Red.GetHashCode());
                    Console.WriteLine("설정한 색상 : brown : " + brown + ", navy : " + navy);
                    break;

                case "2": //메서드
                    Console.WriteLine("부모 toString() : " + base.ToString());
                    Console.WriteLine("재정의 toString() : " + ToString());
                    break;

                case "3": //매개 변수 - 값 매개 변수
                    Console.WriteLine("method(int a, int b)에서 int a, int b가 값 매개 변수");
                    break;

                case "4": //매개 변수 - 참조 매개 변수
                    Console.WriteLine("스왑 전 : " + a + ", " + b);
                    Calculator.Swap(ref a, ref b);
                    Console.WriteLine("스왑 후 :" + a + ", " + b);
                    break;

                case "5": //매개 변수 - 출력 매개 변수
                    Calculator.Divide(a, b, out var quo, out var rem);
                    Console.WriteLine($"Quotient : {quo}, Remainder : {rem}");
                    break;

                case "6": //매개 변수 - 매개 변수 배열
                    Console.WriteLine("Console.WriteLine(fmt - 포멧, object[] - 매개 변수 배열);");
                    break;

                case "7": //메서드 본문 및 지역 변수
                    Squares.WriteSquares();
                    break;

                case "8": //정적 및 인스턴스 메서드
                    Entity.SetNextSerialNo(100);
                    var e1 = new Entity();
                    var e2 = new Entity();
                    Console.WriteLine("e1 : " + e1.GetSerialNo());
                    Console.WriteLine("e2 : " + e2.GetSerialNo());
                    Console.WriteLine("static nextNo : " + Entity.GetNextSerialNo());
                    break;

                case "9": //가상, 재정의 및 추상 메서드
                    Expression e = new Operation(new VariableReference("x"), '*', new Operation(new VariableReference("y"), '+', new Constant(2)));
                    var vars = new Dictionary<string, object>();
                    vars["x"] = 10;
                    vars["y"] = 20;
                    Console.WriteLine(e.Evaluate(vars));
                    vars["x"] = 100;
                    vars["y"] = 200;
                    Console.WriteLine(e.Evaluate(vars));
                    break;
                
                case "10": //메서드 오버로드
                    OverloadingEx.F();            // Invokes F()
                    OverloadingEx.F(1);           // Invokes F(int)
                    OverloadingEx.F(1.0);         // Invokes F(double)
                    OverloadingEx.F("abc");       // Invokes F<T>(T), T is System.String
                    OverloadingEx.F((double)1);   // Invokes F(double)
                    OverloadingEx.F((object)1);   // Invokes F(object)
                    OverloadingEx.F<int>(1);      // Invokes F<T>(T), T is System.Int32
                    OverloadingEx.F(1, 1);        // Invokes F(double, double)
                    break;
                
                case "11": //기타 함수 멤버
                    //생성자
                    var list1 = new MyList<string>();
                    var list2 = new MyList<string>(10);
                    
                    //속성
                    list1.Capacity = 100;   //Invokes set accessor
                    var i = list1.Count;    //Invokes get accessor
                    var j = list1.Capacity; //Invokes get accessor
                    Console.WriteLine("list 1 count    : " + i);
                    Console.WriteLine("list 1 Capacity : " + j);
                    
                    break;
                default:
                    Console.WriteLine(Constants.MENU_IS_NOT_EXIST);
                    break;
            }
        }

        public override string ToString()
        {
            return "재정의된 toString() 메서드";
        }
    }
}