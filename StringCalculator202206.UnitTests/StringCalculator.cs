namespace StringCalculator202206.UnitTests
{
    internal class StringCalculator
    {
        public StringCalculator()
        {
        }

        internal int Add(string number)
        {
            if (string.IsNullOrEmpty(number))
                return 0;

            string[] ints = number.Split(',');
            var sum = 0;

            foreach (string s in ints)
            {
                sum += int.Parse(s);
            }
            return sum;
        }
    }
}