using System;
using System.Collections.Generic;

namespace CSharp.프로그램_구성_요소
{
    public class Operation : Expression
    {
        private Expression _left;
        private char _op;
        private Expression _right;

        public Operation(Expression left, char op, Expression right) =>
        (_left, _op, _right) = (left, op, right);

        public override double Evaluate(Dictionary<string, object> vars)
        {
            double x = _left.Evaluate(vars);
            double y = _right.Evaluate(vars);
            switch (_op)
            {
                case '+': return x + y;
                case '-': return x - y;
                case '*': return x * y;
                case '/': return x / y;
                
                default: throw new Exception("Unknown operator");
            }
        }
    }
}