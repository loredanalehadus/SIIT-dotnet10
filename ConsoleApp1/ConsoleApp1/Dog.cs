using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dog
    {
        //compile time fields
        public const string Owner = "Gigi";

        //Attributes ; name, breed, size,

        // fields - keep the state of the class, and by default are private
        private string name;
        //private Breed breed;

        //property
        // public string Name { get; set; }//automatic property

        public string Name
        { //getter
            get { return name; }

            //setter
            set { name = value; }
        }

        public string OwnerName
        {
            get
            {
                return Owner + " " + Name;
            }
        }

        public int Age { get; set; }

        //Behavior/methods  - Bark , WiggleTail, Eat, Run

        public void Bark()
        {
            // dateOfBirth = DateTime.Now;
            Console.WriteLine($"woof woof, I'm {name}");
        }

        public void Eat()
        {
            Console.WriteLine("mniam mniam, good food, I'm eating...");
        }

        //public static int GetInstanceNumber()
        //{
        //    return numberOfInstances;
        //}
    }
}
