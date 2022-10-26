using System;
using System.Reflection;

namespace CSharp.유형
{
    public class EditBox : IControl, IDataBound
    {
        public void Paint()
        {
            Console.WriteLine("Paint");
        }

        public void Bind(Binder binder)
        {
            Console.WriteLine(binder.ToString());
        }
    }
}