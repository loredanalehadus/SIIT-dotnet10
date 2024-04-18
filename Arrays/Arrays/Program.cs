namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare new array
            int[] myArray = new int[3]; //size of the array
            myArray[0] = 35;
            myArray[1] = -10;
            myArray[2] = 500;
            //myArray[4] = 625; this will throw exception

            myArray[1] = 95012;

            string[] daysOfTheWeek = { "Luni", "Marti", "Joi", "Sambata" }; // reprezentare inline

            // accessing elements from an array
            string[] reversedDays = new string[6];

            int length = daysOfTheWeek.Length;

            for (int i = 0; i < length; i++)
            {
                reversedDays[length - i - 1] = daysOfTheWeek[i];
            }

            //Console.WriteLine(reversedDays[0]);

            // Printing an array
            //Console.WriteLine(daysOfTheWeek); // doesn't print the elements; Output: System.String[]

            // for loop
            for (int i = 0; i < length; i++)
            {
                // Console.WriteLine(daysOfTheWeek[i]);
            }

            // foreach
            foreach (string item in daysOfTheWeek)
            {
                //Console.WriteLine(item);
            }

            // while

            int index = 0;
            while (index < daysOfTheWeek.Length)
            {
                //Console.WriteLine(daysOfTheWeek[index]);
                index++;
            }

            index = 0;
            do
            {
                //Console.WriteLine(daysOfTheWeek[index]);
                index++;
            } while (index < daysOfTheWeek.Length);

            // Readind array from Console
            //Console.WriteLine("Please give an array size:");
            //int arraySize = int.Parse(Console.ReadLine());

            //int[] myArrayFromConsole = new int[arraySize];

            //Console.WriteLine("Please input the values of the array:");

            //for (int i = 0; i < arraySize; i++)
            //{
            //    myArrayFromConsole[i] = int.Parse(Console.ReadLine());
            //}


            // Coping an array
            string[] myArrayCopy = daysOfTheWeek;

            myArrayCopy[0] = "alabala";

            Console.WriteLine(myArrayCopy[0]);
            Console.WriteLine(daysOfTheWeek[0]);

            string[] myArrayClone = (string[])daysOfTheWeek.Clone();

            //object a = 1;
            //object b = new char[2];

            myArrayClone[0] = "Duminica";
            Console.WriteLine(myArrayClone[0]);
            Console.WriteLine(daysOfTheWeek[0]);

            // resize the array

            int[] intArray = new int[5];
            int[] copyArray = intArray; // create backup 

            intArray = new int[6];

            for (int i = 0; i < 5; i++)
            {
                intArray[i] = copyArray[i];
            }

            intArray[5] = 10;

            // declare and create matrix
            int[] array = new int[2];
            array[0] = 1;

            int[,] myMatrix = {
                { 1, 2 },
                { 2, 3 }
            };

            int[,] myMatrix2 = new int[2, 2];
            myMatrix2[0, 0] = 1;
            myMatrix2[0, 1] = 5;

            // Printing a matrix
            // Console.WriteLine(myMatrix); // System.Int32[,]

            for (int row = 0; row < myMatrix.GetLength(0); row++)
            {
                for (int column = 0; column < myMatrix.GetLength(1); column++)
                {
                    Console.Write(myMatrix[row, column]);
                    Console.Write(", ");
                }

                Console.WriteLine();
            }

            // reading a matrix from console
            //Console.WriteLine("Please give a row size:");
            //int rows = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please give a column size:");
            //int columns = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[rows, columns];
            //String inputNumber;

            //for (int row = 0; row < rows; row++)
            //{
            //    for (int column = 0; column < columns; column++)
            //    {
            //        Console.Write("matrix[{0},{1}] = ", row, column);
            //        inputNumber = Console.ReadLine();
            //        matrix[row, column] = int.Parse(inputNumber);
            //    }
            //}
            //Console.WriteLine(); //use Locals window to check the values in the matrix while in debug mode


            // Jagged arrays
            int[] a = new int[7];
            a[0] = 15;


            int[][] jagged = new int[3][];
            // jagged[0][0] = 15;

            myMatrix[0, 0] = 15;

            //  [ [1, 3, 5], [87, 4324, 4324, 42342], [1] ]


            // Properties of Class Array 
            string[] capitals = { "Sofia", "Washingthon", "Londra", "Paris" };

            Console.WriteLine($"Lungimea arrayului este: {capitals.Length}");
            Console.WriteLine($"Numarul de dimensiuni al arrayului este: {capitals.Rank}");
            Console.WriteLine($"Numarul de dimensiuni al matricei este: {myMatrix2.Rank}");

            Console.WriteLine($"Pozitia orasului Londra este {Array.IndexOf(capitals, "Londra")}");
            Console.WriteLine($"La pozitia 2 se afla orasul {capitals[2]}.");

            // array.Reverse()
            var reversed = capitals.Reverse();
            //Array.Reverse(capitals);

            foreach (var city in reversed)
            {
                Console.WriteLine(city);
            }

            Array.Sort(capitals);
            foreach (var city in capitals)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine(capitals[2]);

            Array.Clear(capitals);
        }
    }
}
