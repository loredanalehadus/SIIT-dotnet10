namespace ExceptionsPrep
{
    public class Program
    {
        static void Main()
        {
            string fileName = "WrongTextFile.txt";
            ReadFile(fileName);


            Dictionary<string, double> studentGrades = new Dictionary<string, double>();
        }

        static void ReadFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"The file '{fileName}' does not exist.");
                return;
            }

            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }


        //static void ReadFile(string filename)
        //{
        //    StreamReader reader = null;
        //    try
        //    {
        //        reader = new StreamReader(filename);
        //        while (!reader.EndOfStream)
        //        {
        //            string line = reader.ReadLine();
        //            Console.WriteLine(line);
        //        }
        //        reader.Close();
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        Console.WriteLine($"The file '{filename}' does not exist.");
        //    }
        //    finally
        //    {
        //        if (reader != null)
        //        {
        //            reader.Close();
        //        }
        //    }
        //}


    }
}