using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Dog
    {
        // Attributes

        // Fields: keep the state of the class
        private string name;
        private string breed;

        // Constructors
        // parameterless constructor
        public Dog() 
        {
            name = "Undefined";
            breed = "NotKnown";
        }

        // constructor with parameters
        public Dog(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
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

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        // Behavior
    }
}
