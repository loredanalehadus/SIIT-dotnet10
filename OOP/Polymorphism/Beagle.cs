using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Beagle : Dog
    {
        public override void Bark()
        {
            Console.WriteLine("Beagle bark");
        }

    }
}
