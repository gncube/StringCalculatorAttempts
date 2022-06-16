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
    }
}