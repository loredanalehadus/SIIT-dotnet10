using System.Collections;

namespace Collections.ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Yaris";

            Car car2 = new Car();
            car2.Make = "VW";
            car2.Model = "Touran";

            //Car[] myCars = new Car[2];
            //myCars[0] = car1;
            //myCars[1] = car2;

            //ArrayList myArrayList = new ArrayList();
            //myArrayList.Add(car1);
            //myArrayList.Add(car2);

            Book book = new Book();
            //myArrayList.Add(book);

            //foreach (Car car in myArrayList)
            //{
            //    Console.WriteLine(car.Make);
            //}

            // List<T> 
            List<Car> myCars = new List<Car>();
            myCars.Add(car1);
            myCars.Add(car2);
            //myCars.Add(book);

            foreach (Car car in myCars)
            {
                Console.WriteLine(car.Make);
            }            
        }
    }
}

class Car
{
    public string Model { get; set; }
    public string Make { get; set; }
}

class Book
{
    public string Autor { get; set; }
    public string Name { get; set; }
}