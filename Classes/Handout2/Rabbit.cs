namespace Handout2
{
    public enum EyeColor
    {
        Blue,
        Red,
        Black
    }

    public enum FurColor
    {
        White,
        Brown,
        Black,
        Grey
    }

    public enum Gender
    {
        Male,
        Female
    }

    public class Rabbit
    {
        public EyeColor EyeColor { get; set; }
        public FurColor FurColor { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }

        // Constructor to initialize a rabbit with specified properties
        public Rabbit(EyeColor eyeColor, FurColor furColor, Gender gender, DateTime birthDate)
        {
            EyeColor = eyeColor;
            FurColor = furColor;
            Gender = gender;
            BirthDate = birthDate;
        }

        // Method to calculate the rabbit's age in years
        public double GetAgeInYears()
        {
            var now = DateTime.Today;
            var age = now.Year - BirthDate.Year;
            return age;
        }

        // A formatted description of the rabbit
        public override string ToString()
        {
            return $"Rabbit [EyeColor={EyeColor}, FurColor={FurColor}, Gender={Gender}, BirthDate={BirthDate:yyyy-MM-dd}, Age={GetAgeInYears():0.1} years]";
        }
    }
}
