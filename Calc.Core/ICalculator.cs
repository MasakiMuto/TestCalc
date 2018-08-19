using System.ComponentModel;

namespace Calc
{
    public interface ICalculator : INotifyPropertyChanged
    {
        void Input(int digit);
        void Input(Operator op);
        void Clear();
        
        string DisplayString { get; }
        int Operand { get; }
    }
}