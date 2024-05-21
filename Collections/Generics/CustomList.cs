using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Generics.Program;

namespace Generics
{
    public class CustomList<T> where T : Animal
    {
        private List<T> values;

        public CustomList()
        {
            values = new List<T>();
        }

        public void Add(T item)
        {
            values.Add(item);
        }

        public void Remove(T item)
        {
            values.Remove(item);
        }

        public bool Contains(T item)
        {
            return values.Contains(item);
        }
    }
}
