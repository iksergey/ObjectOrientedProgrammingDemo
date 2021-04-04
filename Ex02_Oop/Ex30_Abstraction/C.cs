using System;

namespace Ex030_Abstraction
{
    // Ошибка CS0621 виртуальные и абстрактные члены не могут быть закрытыми.
    abstract class C
    {
        public abstract void SampleMethod1();
        public abstract int Property { get; set; }
        public abstract Type this[int index] { get; set; }
        public abstract event Action Event;
    }


























    abstract class C1
    {
        public abstract void SampleMethod1();
        public abstract int Property { get; set; }
        public abstract Type this[int index] { get; set; }
        public abstract event Action Event;

        public void Method()
        {
            Console.WriteLine("Method()");
        }
    }
}
