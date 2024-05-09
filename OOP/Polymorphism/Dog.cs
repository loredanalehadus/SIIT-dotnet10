using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Dog
    {
        public virtual void Bark()
        {
            //this.name = "Cutu";
            Console.WriteLine("Dog - Ham ham!");
        }
    }
}
