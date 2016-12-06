using System;
using Xunit;

namespace Calc.Domain
{
    public class CalculatorTests
    {
        [Fact]
        public void TestAdd() 
        {
            Calculator calc = new Calculator();
            int result = calc.add(3,4);
            Assert.Equal(7, result);
        }
    }
}