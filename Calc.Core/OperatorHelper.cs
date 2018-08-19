using System;

namespace Calc
{
    public static class OperatorHelper
    {
        public static string ToString(Operator op)
        {
            switch (op)
            {
                case Operator.None:
                    return string.Empty;
                case Operator.Enter:
                    return "=";
                case Operator.Add:
                    return "+";
                case Operator.Sub:
                    return "-";
                case Operator.Mul:
                    return "*";
                case Operator.Div:
                    return "/";
                default:
                    throw new ArgumentOutOfRangeException(nameof(op), op, null);
            }
        }
    }
}