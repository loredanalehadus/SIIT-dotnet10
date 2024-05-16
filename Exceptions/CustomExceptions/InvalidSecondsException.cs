using System.Runtime.Serialization;

namespace CustomExceptions
{
    [Serializable]
    internal class InvalidSecondsException : Exception
    {
        public InvalidSecondsException(string message = "The value should be between 0 and 59") : base(message)
        {
        }
    }
}