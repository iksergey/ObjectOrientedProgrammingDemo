using System;

namespace Ex027_Polymorphism
{

    static class Extensions
    {
        public static int Method(this string v) 
        {
            Console.WriteLine($"Method(this string v) {v.GetType()}"); 
            return v.GetHashCode();
        }
        public static int Method(this int v) 
        { 
            Console.WriteLine($"Method(this int v) {v.GetType()}"); 
            return v.GetHashCode(); 
        }
    }

    class A
    {
        public void Method() { Console.WriteLine("Method()"); }
        public void Method(int v) { Console.WriteLine("Method(int v)"); }
        public void Method(string v) { Console.WriteLine("Method(string v)"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            a.Method();
            a.Method(28091990);
            a.Method("15062007");

            String.Empty.Method()
                        .Method();
            



        }
    }
}
