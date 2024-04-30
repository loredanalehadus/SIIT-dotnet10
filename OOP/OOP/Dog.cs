using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Dog
    {
        private readonly string name;

        public string Name { get { return name; } }

        //public string name;

        public Dog(string name)
        {
            // this.name = "grivei";
            this.name = name;
            Console.WriteLine("Dog class");
        }


        public void Bark()
        {
            //this.name = "Cutu";
            Console.WriteLine("Dog - Ham ham!");
        }

        public void Eat()
        {
            Console.WriteLine("dog, eats");
        }
    }
}
