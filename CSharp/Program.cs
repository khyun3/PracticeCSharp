using System;
using System.Diagnostics;

namespace CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var introduction = new Introduction();
            var menu = "0";
            menu = Console.ReadLine();

            while (!menu.Equals("-1"))
            {
                switch (menu)
                {
                    case "1": //1. 소개
                        introduction.select("1");
                        break;
                    case "2": //2. 유형

                        break;
                    default:
                        Console.WriteLine("메뉴 없음");
                        break;
                }

                menu = Console.ReadLine();
            }
        }
    }
}