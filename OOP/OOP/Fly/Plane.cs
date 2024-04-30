using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Fly
{
    public class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("vrum vrum, starting the engines!");
        }
    }
}
