namespace StringCalculatorCS
{
    internal class InvalidInputException : Exception
    {
        public InvalidInputException(string? message) : base(message)
        {
        }
    }
}
