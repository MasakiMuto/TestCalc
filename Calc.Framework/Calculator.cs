using System.ComponentModel;
using Calc;

namespace Calc.Framework
{
    public class Calculator : ICalculator
    {
        public void Input(int diigt)
        {
            throw new System.NotImplementedException();
        }

        public void Input(Operator op)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            
        }

        public string DisplayString { get; private set; }
        public int Operand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}