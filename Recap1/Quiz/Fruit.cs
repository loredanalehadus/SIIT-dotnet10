using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public abstract class Fruit
    {
        public Fruit()
        {
            Console.WriteLine("Fruit constructor called!");
        }
    }

    public class Orange : Fruit
    {
        private string name;

        public Orange()
        {
            
        }

        public Orange(string name)
        {

            this.name = name;

            Console.WriteLine("Orange constructor called!");
        }
    }

    //Orange mySweetOrange = new Orange();

}
