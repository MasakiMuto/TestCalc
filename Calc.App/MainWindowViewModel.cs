using System;
using System.Reactive.Disposables;
using Calc.Framework;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;


namespace Calc.App
{
    public sealed class MainWindowViewModel : IDisposable
    {
        private readonly CompositeDisposable _compositeDisposable;
        private readonly ICalculator _calculator;

        public ReactiveCommand<int> NumberCommand { get; }
        public ReadOnlyReactivePropertySlim<string> Display { get; }

        public MainWindowViewModel()
        {
            _compositeDisposable = new CompositeDisposable();
            _calculator = new Calculator();
            NumberCommand = new ReactiveCommand<int>()
                .AddTo(_compositeDisposable);
            NumberCommand.Subscribe(x => _calculator.Input(x))
                .AddTo(_compositeDisposable);

            Display = _calculator.ObserveProperty(x => x.DisplayString)
                .ToReadOnlyReactivePropertySlim()
                .AddTo(_compositeDisposable);
        }

        public void Dispose()
        {
            _compositeDisposable.Dispose();
        }
    }
}