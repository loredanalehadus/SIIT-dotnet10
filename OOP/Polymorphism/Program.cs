namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var result = Sum(3, 5);
            //var result2 = Sum(0.5f);

            Beagle beagle = new Beagle();
            beagle.Bark();

            Dog dog = beagle;
            dog.Bark();
        }

        // Method overloading
        // semnatura este diferita (semnatura metodei = numele metodei + nr si tipul parametrilor)
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        //public static int Sum(int x, int y)
        //{
        //    return 0;
        //}

        public static double Sum(double x, double y)
        {
            return (double)x + y;
        }

        public static float Sum(float x)
        {
            return x + 10.5f;
        }
    }
}
