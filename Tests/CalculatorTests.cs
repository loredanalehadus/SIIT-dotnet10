using UnitTesting;

namespace Tests
{
    public class CalculatorTests
    {
        //Best practice: naming tests:
        // <method name> + <intention> + <result>

        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(-5, 5, 0)]
        [InlineData(-15, -5, -20)]
        public void SumShouldAddTwoNumbers(int a, int b, int expected)
        {
            // Arrange
            //int a = 1;
            //int b = 2;
            //int expected = 3;
            var sut = new Calculator();

            // Act
            var result = sut.Sum(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}