namespace StringCalculatorCS
{
    internal static class StringCalculator
    {
        public static List<string> Delimiters { get; } = [",", "\n"];
        public static int Add(String numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return 0;
            return FliterNumbersBiggerThan1000(NegativeCheck(ExtractNumbers(ExtractDelimiters(numbers)))).Sum();

        }
        private static string ExtractDelimiters(String numbers)
        {
            if (!numbers.StartsWith("//")) return numbers;
            var inputs = numbers.Split('\n', 2);
            var customDelimiters = inputs[0].Split(new char[] { '[', ']', '/' }, StringSplitOptions.RemoveEmptyEntries);
            Delimiters.AddRange(customDelimiters);
            return inputs[1];
        }

        private static int[] ExtractNumbers(string numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return [];
            return Array.ConvertAll(
                 CheckInvaildInput(
                     numbers.Split(Delimiters.ToArray(), StringSplitOptions.None)
                 ),
                 int.Parse
             );
        }

        private static string[] CheckInvaildInput(string[] numbers)
        {
            var emptyItems = numbers.Where(x => x == "" || x == " ").ToArray();
            if (emptyItems.Length > 0)
            {
                throw new InvalidInputException("Invaild input format");
            }
            return numbers;
        }

        private static int[] NegativeCheck(int[] numbers)
        {
            var negativeNumbers = numbers.Where((x) => x < 0).ToArray();
            if (negativeNumbers.Length > 0)
            {
                throw new NegativesNoAllowedException(negativeNumbers);
            }
            return numbers;
        }

        private static int[] FliterNumbersBiggerThan1000(int[] numbers)
        {
            return numbers.Where((x) => x <= 1000).ToArray();
        }
    }
}
