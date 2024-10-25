namespace Quiz
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = new ClassA();
            var b = new ClassB();


            //b.Method1();
            b.Method2();
            //a.Method2();
            //a.Method1();

            Orange mySweetOrange = new Orange();

            Generic<String> g = new Generic<String>();
            g.Field = "Hello";
            Console.WriteLine(g.Field);

            ////////////////////////

            //string userResponse;
            //foreach (string name in names)
            //{
            //    string userResponse = AskUserIfNameIsOk(name);
            //    // other code
            //}


        }
    }

    public class ClassA
    {
        protected void Method1()
        {
            // do something                               
        }
    }

    public class ClassB : ClassA
    {
        public void Method2()
        {
            base.Method1();
            // do something else
        }
    }

    public interface IPerson { }

   public class Person 
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "Person: " + Name + " " + Age;
        }
    }

    public class Generic<T>
    {
        public T Field;
    }


    public static class GlobalData
    {
        public const string ConnStr = "kdajd"; //compile time
        public static readonly string ConnStr2 = GetConnectionString(); // runtime
        private static string GetConnectionString() { /* return something here */ return null; }
    }

    public struct MyTipe // tratat ca un tip primitiv de data
    {
        //
    }

    public sealed class MyClass
    {

    }

    //public class MyClass2 : MyClass
    //{

    //}
}
