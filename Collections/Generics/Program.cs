namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Swap<int>(5, 10);

            Person p1 = new Person();
            Person p2 = new Person();

            Swap(p1, p2);
            Swap("duck", "horse");

            Animal animal = new Animal();
            Horse horse = new Horse();

            Swap(animal, horse);
            /*
            CustomList<int> myIntList = new CustomList<int>();
            myIntList.Add(10);
            myIntList.Add(20);
            Console.WriteLine(myIntList.Contains(10));

            CustomList<Person> persons = new CustomList<Person>();
            persons.Add(p1);
            persons.Remove(p1);
            */

            CustomList<Animal> animals = new CustomList<Animal>();
            CustomList<Horse> horses = new CustomList<Horse>();

            Box<int> myIntBox = new Box<int>();
            myIntBox.Add(2);
            Console.WriteLine(myIntBox.Count);

        }

        static void Swap<T>(T a, T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //static void Swap(int a, int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}

        //static void Swap(Person a, Person b)
        //{
        //    Person temp = a;
        //    a = b;
        //    b = temp;
        //}

        class Person
        {
            public Person()
            {                
            }

            public Person(string name)
            {

            }
        }

        public class Animal { }

        public class Horse : Animal { }
    }
}
