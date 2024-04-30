using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Fly
{
    public interface IBird : IFlyable, ILandBound
    {
        bool Migrates { get; set; }
    }
}
