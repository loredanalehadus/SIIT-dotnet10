using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Beagle : Dog
    {
        //public Beagle(): base("N/A")
        //{
            
        //}

        public Beagle(string name) : base(name)
        {
            Console.WriteLine("Beagle - ctor");
        }


        public void DoTrick()
        {
            Console.WriteLine("I'm doing tricks!");
        }

        public void Bark()
        {
            Console.WriteLine("Beagle bark");
        }
    }
}
