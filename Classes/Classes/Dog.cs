using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum Breed
    {
        NotKnown, // 0
        Beagle,   // 1
        Dalmatian,
        Pitbull,
        Husky
    }

    enum Level
    {
        Begginer = 100,
        Intermediate = 200,
        Advanced = 300
    }

    internal class Dog
    {
        // Attributes

        //Constants
        public const string OWNER = "Gigi"; // compile time
        public readonly DateTime birthDate; // runtime

        // Static field
        public static int numberOfInstances;

        // Fields: keep the state of the class
        private string name;
        private Breed breed;

        // Constructors
        // parameterless constructor

        public Dog() : this("Undefined", Breed.NotKnown)
        {
            //name = "Undefined";
            //breed = "NotKnown";
            birthDate = DateTime.Now;
            numberOfInstances++;
        }

        // constructor with parameters
        //public Dog(string name, string breed)
        //{
        //    this.name = name;
        //    this.breed = breed;
        //}

        public Dog(string name, Breed breed)
        {
            this.name = name;
            this.breed = breed;
            numberOfInstances++;
        }

        // Properties
        // public string Name { get; set; } // automatic property

        public string Name
        {
            // getter
            get
            {
                return name;
            }
            // setter
            set
            {
                name = value;
            }
        }

        public Breed Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public string OwnerName // read only property
        {
            get
            {
                return OWNER + " " + Name;
            }
        }

        public long SecurityNumber { private get; set; } // write-only



        // Behavior
        public void Bark()
        {
            Console.WriteLine($"woof woof, I'm {name}");
        }


        // static metod
        public static int GetInstanceNumber()
        {
            return numberOfInstances;
        }

    }
}
