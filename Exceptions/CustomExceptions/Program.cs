namespace CustomExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Song song = new Song();
                song.Artist = "A";
            }
            catch (InvalidSongException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Song song2 = new Song();
                song2.Name = "Abc";
                song2.Artist = "Smiley";
                song2.Minutes = 30;
                song2.Seconds = 5;
            }
            catch (InvalidSongNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidArtistException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidMinutesException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidSecondsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidSongException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Song mySong = new Song();
                mySong.Name = "AbC";
                mySong.Artist = "Devinson";
                mySong.Minutes = 30;
                mySong.Seconds = 4;
            }
            catch (InvalidSongException ex) when (ex is InvalidMinutesException)
            {
                Console.WriteLine(ex.Message + typeof(InvalidMinutesException));
            }
            catch (InvalidSongException ex) when (ex is InvalidArtistException)
            {
                Console.WriteLine(ex.Message + typeof(InvalidArtistException));
            }

        }
    }
}
