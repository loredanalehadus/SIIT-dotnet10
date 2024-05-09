using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Horse : GrassFeedMammal, IFourLeggedMammal
    {
        public bool HasPaws { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AreCopite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int ReturnSpeed()
        {
            return 60;
            //throw new NotImplementedException();
        }

        public override void Sleep()
        {
            throw new NotImplementedException();
        }
    }
}
