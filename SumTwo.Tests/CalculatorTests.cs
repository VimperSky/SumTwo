using System;
using Xunit;
using Moq;

namespace SumTwo.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(5, -1)]
        [InlineData(7, 1)]
        [InlineData(-7, 6)]
        [InlineData(-7, 8)]
        [InlineData(0, 0)]
        [InlineData(0, 2)]
        [InlineData(0, -2)]
        [InlineData(2, 0)]
        [InlineData(-2, 0)]        
        public void SignOfBiggerSign(int a, int b)
        {
            // Arrange
            var bigger = (Math.Abs(a) > Math.Abs(b)) ? a : b;
            var biggerSign = (bigger >= 0) ? 1 : -1;

            // Act
            var mock = new Mock<INumberProvider>();
            mock.Setup(x => x.A).Returns(a);
            mock.Setup(x => x.B).Returns(b);
            var calc = new Calculator(mock.Object);
            var sum = calc.Sum();

            // Assert
            Assert.True(sum * biggerSign >= 0);
        }
    }
}