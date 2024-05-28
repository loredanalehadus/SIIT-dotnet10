namespace Lambdas
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public DateTime BirthDate { get => DateTime.Now; } // automatic property
         
        //public DateTime BirthDate2
        //{
        //    get
        //    {
        //        return DateTime.Now;
        //    }
        //}
    }
}
