using System.Collections.Generic;

namespace CSharp.프로그램_구성_요소
{
    public class Constant : Expression
    {
        private double _value;

        public Constant(double value) => _value = value;
        public override double Evaluate(Dictionary<string, object> vars) => _value;
    }
}