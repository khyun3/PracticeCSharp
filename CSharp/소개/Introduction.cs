using System.Diagnostics;

namespace CSharp
{
    public class Introduction : SubMenuSelecter
    {
        private Hello hello;

        public Introduction() => hello = new Hello();
        
        public void select(string subMenu)
        {
            switch (subMenu)
            {
                case "1":
                    hello.print();
                    break;
                default:
                    break;
            }
            
        }
    }
}