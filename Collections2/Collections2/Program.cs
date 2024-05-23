using Lists;
using System.Collections;

namespace Collections2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare a list
            List<string> list = new List<string>();
            Console.WriteLine($"Number of elements in the list: {list.Count}");

            //add elements
            list.Add("lapte");
            list.Add("oua");
            list.Add("salata");
            list.Add("ciocolata");

            //ArrayList oldList = new ArrayList();
            //oldList.Add("lapte");
            //oldList.Add(12);
            //oldList.Add(new object());

            Console.WriteLine($"Number of elements in the list: {list.Count}");

            // Console.WriteLine(list);
            // union of list
            List<string> wifeShoppingList = new List<string> { "ciocolata", "cafea", "pantofi", "parfum" };

            list.AddRange(wifeShoppingList);

            // print elements of a list
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            // sort the list
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            // remove an element
            //list.Remove("ciocolata");
            list.Remove("pantofi");

            list.RemoveAll(x => x == "ciocolata");

            Console.WriteLine($"Mai exista pantofi in list? {list.Contains("ciocolata")}");
            Console.WriteLine($"Mai exista pantofi in list? {list.Contains("pantofi")}");

            // reverse 
            List<int> intList = new List<int> { 5, 4, 3, 2, 1 };
            intList.Reverse();

            Person person1 = new Person("Vasile", "Popescu");
            Person person2 = new Person("Emilia", "Nae");

            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);

            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }

            Console.WriteLine(people[1].FirstName);

            //clear elements
            people.Clear();
            Console.WriteLine($"Number of elements in the list: {people.Count}");

        }
    }
}
