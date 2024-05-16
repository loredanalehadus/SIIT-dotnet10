namespace CustomExceptions
{
    public class InvalidMinutesException : InvalidSongException
    {
        public InvalidMinutesException(string message = "Song length should not be more than 14 min.") : base(message)
        {
            
        }
    }
}
