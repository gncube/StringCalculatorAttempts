namespace StringCalculator202206.UnitTests
{
    public class StringCalculatorShould
    {
        [Fact]
        public void ReturnZeroGivenEmptyString()
        {
            var calculator = new StringCalculator();
            var actual = calculator.Add("");

            var expected = 0;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1,2", 3)]
        public void ReturnSumGivenStringOfNumbers(string numbers, int expectedResult)
        {
            var calculator = new StringCalculator();
            var actual = calculator.Add(numbers);

            Assert.Equal(expectedResult, actual);
        }
    }
}