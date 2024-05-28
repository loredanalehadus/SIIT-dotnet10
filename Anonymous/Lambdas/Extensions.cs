using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    public static class Extensions
    {
        // just a static method
        public static int WordCount(string sentence)
        {
            int wordCount = sentence.Split(' ').Length;
            return wordCount;
        }

        // extension method
        public static int WordCountExtension(this string sentence)
        {
            int wordCount = sentence.Split(' ').Length;
            return wordCount;
        }

        public static bool GreaterThan(this int a, int b)
        {
            return a > b; // a.GreaterThan(b);
        }

        public static IEnumerable<Person> Filter1(this IEnumerable<Person> persons, string country)
        {
            return persons.Where(p => p.Country == country).ToList();
        }

        public static IEnumerable<Person> Filter(this IEnumerable<Person> persons, GroupType type, string groupValue)
        {
            switch (type)
            {
                case GroupType.Country:
                    return persons.Where(x => x.Country == groupValue).Select(x => x);

                case GroupType.City:
                    return persons.Where(x => x.City == groupValue).Select(x => x);
                //case GroupType.LastName:

            }
            return persons;
        }

    }

    public enum GroupType
    {
        Country,
        City,
        LastName
    }
}
