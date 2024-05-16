using System.Runtime.Serialization;

namespace CustomExceptions
{
    [Serializable]
    internal class InvalidSongNameException : Exception
    {
        public InvalidSongNameException(string message = "Song name should be between 3 and 30 symbols.") : 
            base(message)
        {
        }
    }
}