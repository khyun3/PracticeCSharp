using System;
using CSharp.Properties;

namespace CSharp.프로그램_구성_요소
{
    public class ProgramComponent : ISubMenuSelector
    {
        public void Select(string subMenu)
        {
            var brown = new Color(165,42,42);
            var navy = new Color(0,0,80);
            switch (subMenu)
            {
                case "1":
                    Console.WriteLine("스테틱 색상 : red : "+ Color.Red + ", hashCode : " + Color.Red.GetHashCode());
                    Console.WriteLine("설정한 색상 : brown : " + brown +", navy : " + navy);
                    break;
                default:
                    Console.WriteLine(Constants.MENU_IS_NOT_EXIST);
                    break;
            }
        }
    }
}