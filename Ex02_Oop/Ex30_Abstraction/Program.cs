using static System.Console;

namespace Ex030_Abstraction
{

    class Program
    {
        static void Main(string[] args)
        {

            //// new A(); // нельзя

            //new B();    // abstract - public A()
            //            // public B()

            //ReadLine(); Clear();

            //IFromFInterface f1 = new F();
            //f1.SampleMethod4(); // F.SampleMethod4()
            //f1.SampleMethod5(); // IFromFInterface.SampleMethod5()

            //F f2 = new F();
            //f2.SampleMethod4(); // F.SampleMethod4()

            ////f2.SampleMethod5(); 
            //// Ошибка CS1061  "F" не содержит определения "SampleMethod5"

            //ReadLine(); Clear();

            H1.Test();
            H2.Test();
            H3.Test();
            H4.Test();

            ReadLine(); Clear();



        }
    }
}
