using System.Collections.Generic;

namespace CSharp.프로그램_구성_요소
{
    public abstract class Expression
    {
        public abstract double Evaluate(Dictionary<string, object> vars);
    }
}