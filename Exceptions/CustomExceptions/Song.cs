namespace CustomExceptions
{
    internal class Song
    {
        private string name;
        private string artist;
        private int minutes;
        private int seconds;

        //public Song(string name)
        //{
        //    Name = name;
        //}

        // length min 3, max 30
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 3 && value.Length <= 30)
                {
                    name = value;
                    return;
                }

                throw new InvalidSongNameException();
                //throw new InvalidSongException("Name should be between 3 and 30 characters");
                //error
            }
        }

        // lenght min 2, max 20
        public string Artist
        {
            get
            {
                return artist;
            }

            set
            {
                if (value.Length < 2 || value.Length > 20)
                {
                    throw new InvalidArtistException();
                }

                artist = value;
            }
        }

        // no more than 14
        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 0 && value <= 14)
                {
                    minutes = value;
                }
                else
                {
                    throw new InvalidMinutesException();
                }
            }
        }

        // no more than 59
        public int Seconds
        {
            get { return this.seconds; }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    seconds = value;
                }
                else
                {
                    throw new InvalidSecondsException();
                }
            }
        }
    }
}
