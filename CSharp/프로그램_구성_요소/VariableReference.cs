using System;
using System.Collections.Generic;

namespace CSharp.프로그램_구성_요소
{
    public class VariableReference : Expression
    {
        private string _name;

        public VariableReference(string name) => _name = name;

        public override double Evaluate(Dictionary<string, object> vars)
        {
            var value = vars[_name] ?? throw new Exception($"Unknown variable : {_name}");
            return Convert.ToDouble(value);
        }
    }
}