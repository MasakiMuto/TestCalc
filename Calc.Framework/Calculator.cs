using System.ComponentModel;
using Calc;

namespace Calc.Framework
{
    [Notify]
    public class Calculator : ICalculator, INotifyPropertyChanged
    {
        public void Input(int digit)
        {
            Operand = Operand * 10 + digit;
            DisplayString = Operand.ToString();
        }

        public void Input(Operator op)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
        }

        public string DisplayString
        {
            get => _displayString;
            private set => SetProperty(ref _displayString, value, DisplayStringPropertyChangedEventArgs);
        }

        public int Operand
        {
            get => _operand;
            private set => SetProperty(ref _operand, value, OperandPropertyChangedEventArgs);
        }

        #region NotifyPropertyChangedGenerator

        public event PropertyChangedEventHandler PropertyChanged;

        private string _displayString;

        private static readonly PropertyChangedEventArgs DisplayStringPropertyChangedEventArgs =
            new PropertyChangedEventArgs(nameof(DisplayString));

        private int _operand;

        private static readonly PropertyChangedEventArgs OperandPropertyChangedEventArgs =
            new PropertyChangedEventArgs(nameof(Operand));

        private void SetProperty<T>(ref T field, T value, PropertyChangedEventArgs ev)
        {
            if (!System.Collections.Generic.EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                PropertyChanged?.Invoke(this, ev);
            }
        }

        #endregion
    }
}