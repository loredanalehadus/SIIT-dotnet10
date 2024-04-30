using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Robots
{
    public class Citizen : IPerson, IRezident
    {
        //implement explicitly some members

        string IPerson.Name
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        string IRezident.Name
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        string IPerson.Country
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        string IRezident.Country
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        void IPerson.GetName()
        {
            throw new NotImplementedException();
        }

        void IRezident.GetName()
        {
            throw new NotImplementedException();
        }
    }
}
