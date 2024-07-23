using UnitTesting;

namespace Tests
{
    public class CalculatorTests
    {
        //Best practice: naming tests:
        // <method name> + <intention> + <result>

        [Fact]
        public void SumShouldAddTwoNumbers()
        {
            // Arrange
            int a = 1;
            int b = 2;
            int expected = 3;
            var sut = new Calculator();

            // Act
            var result = sut.Sum(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}