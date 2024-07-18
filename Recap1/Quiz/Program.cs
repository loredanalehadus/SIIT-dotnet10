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
}
