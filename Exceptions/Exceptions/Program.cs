namespace Exceptions
{
    internal class Program
    {
        static void Main()
        {
            ReadFromFile("myFile.txt");

            try
            {
                ReadFromFile2("myFile.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ReadFromFile(string fileName)
        {
            var reader = new StreamReader(fileName);

            try
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine($"File {fileName} is not found");
                Console.WriteLine(fnfe.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.StackTrace);
            }
            finally
            {
                reader.Close();
            }
        }

        static void ReadFile(string fileName)
        {
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                string line = streamReader.ReadLine();
                Console.WriteLine(line);
            }
        }

        // method without catching the exeptions

        static void ReadFromFile2(string fileName)
        {
            // check if file exists
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"File {fileName} is not found");
                return;
            }

            var reader = new StreamReader(fileName);
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    //reader.Close();
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                    //reader.Close();                   
                }
            }

        }

    }
}
