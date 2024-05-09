using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class GrassFeedMammal : Mammal
    {
        public abstract int ReturnSpeed();
        public abstract void Sleep();

        public void DigestGrass()
        {
            Console.WriteLine("I'm grass fed, I eat grass!");
        }
    }
}
