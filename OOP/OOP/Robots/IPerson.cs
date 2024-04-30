using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Robots
{
    public interface IPerson
    {
        void GetName();
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
