using System;

namespace Ex030_Abstraction
{
    class F : IFromFInterface
    {
        public F()
        {
            //var f = new IFromFInterface.MyClass();
            //Console.WriteLine($"f.GetType() = {f.GetType()}");
        }

        public int SampleMethod2() => 0;

        public void View() => (this as IFromFInterface).SampleMethod1();

        public void SampleMethod4() { Console.WriteLine("F.SampleMethod4()"); }

    }
}
