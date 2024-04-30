using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Fly
{
    public class Bird : IBird // IFlyable, ILandBound
    {
        public bool Migrates
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("flap flap, I'm a bird and I fly!");
        }

        public void Walk()
        {
            Console.WriteLine("bird walking!");
        }

        public void Sing()
        {
            Console.WriteLine("singing, waking up people!");
        }
    }
}
