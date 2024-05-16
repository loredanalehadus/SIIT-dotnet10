using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class ExceptionExplained
    {
        public void Demo()
        {
            try
            {
                // codul care poate genera o exceptie
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (FormatException fe)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Console.WriteLine("This block executes all the time");
            }


            try
            {
                // open DB connection
            }
            finally
            {
                // close DB connection
            }

            // equivalent to
            //using (/*open connection to DB*/)
            //{
            //    // code to manipulate DB
            //    // CRUD operations
            //    // no need to close connection do DB
            //}
        }
    }
}
