using OOP.Fly;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beagle beagle = new Beagle("Lola");
            //beagle.name = "baubau";
            beagle.Bark();
            beagle.Eat();
            beagle.DoTrick();
            Console.WriteLine(beagle.Name);

            Dog dog = new Dog("Grivei");
            dog = beagle;
            dog.Eat();
            dog.Bark();


            Bichon bichon = new Bichon("gigi");
            bichon.Bark();
            bichon.Eat();

            Bird bird = new Bird();
            bird.Fly();
            bird.Walk();

            Plane plane = new Plane();
            plane.Fly();

            var paperPlane = new PaperAirplane();

            IFlyable flyableObject = new PaperAirplane();
            flyableObject = bird;
            flyableObject.Fly();

            AngryBird angryBird = new AngryBird();

            IFlyable[] flyables = new IFlyable[] { bird, plane, angryBird, paperPlane };

            for (int i = 0; i < flyables.Length; i++)
            {
                flyables[i].Fly();
            }

        }
    }
}
