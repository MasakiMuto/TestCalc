using System;
using Xunit;

namespace Calc.Framework.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Test1()
        {
            var calc = new Calculator();
            calc.Clear();
            Assert.Equal(0, calc.Operand);
        }
    }
}