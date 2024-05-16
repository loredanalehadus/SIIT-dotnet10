using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class InvalidSongException : ApplicationException
    {
        // this: aceasta instanta de clasa
        // base: instanta parintelui

        public InvalidSongException(string message = "Invalid song") : base(message)
        {
        }
    }
}
