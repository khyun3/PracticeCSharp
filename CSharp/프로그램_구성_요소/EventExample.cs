using System;

namespace CSharp.프로그램_구성_요소
{
    public class EventExample
    {
        private static int s_changeCount;

        static void ListChanged(object sender, EventArgs e)
        {
            s_changeCount++;
            Console.WriteLine("이벤트 발생 : 카운트 증가 : " + s_changeCount);
        }

        public static void Usage()
        {
            var names = new MyList<string>();
            names.Changed += new EventHandler(ListChanged);
            names.Add("Liz");
            names.Add("Martha");
            names.Add("Beth");
        }
    }
}