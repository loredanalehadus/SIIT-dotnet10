namespace CustomExceptions
{
    public class InvalidArtistException : InvalidSongException
    {
        public InvalidArtistException(string message = "Artist name should be between 2 and 20 characters") :
            base(message)
        {
        }
    }
}
