using System;

namespace CSharp.프로그램_구성_요소
{
    public static class OverloadingEx
    {
        public static void F() => Console.WriteLine("F()");
        public static void F(object x) => Console.WriteLine($"F(Object) {x}");
        public static void F(int x) => Console.WriteLine($"F(int) {x}");
        public static void F(double x) => Console.WriteLine($"F(double) {x}");
        public static void F<T>(T x) => Console.WriteLine($"F<T>(T) T is {typeof(T)}");
        public static void F(double x, double y) =>  Console.WriteLine($"F(double, double)");
    }
}