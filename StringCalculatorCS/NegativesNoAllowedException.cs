
namespace StringCalculatorCS
{
    [Serializable]
    internal class NegativesNoAllowedException : Exception
    {

        public NegativesNoAllowedException()
        {
        }

        public NegativesNoAllowedException(IEnumerable<int> numbers) : base($"Negative numbers not allowd {string.Join(',', numbers)}")
        {
        }

        public NegativesNoAllowedException(string? message) : base(message)
        {
        }

        public NegativesNoAllowedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}