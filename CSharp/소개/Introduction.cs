using System;
using CSharp.Properties;

namespace CSharp.소개
{
    public class Introduction : ISubMenuSelector
    {
        private Hello _hello;

        public Introduction() => _hello = new Hello();

        public void Select(string subMenu)
        {
            switch (subMenu)
            {
                case "1":
                    _hello.print();
                    break;
                default:
                    Console.WriteLine(Constants.MENU_IS_NOT_EXIST);
                    break;
            }
        }
    }
}