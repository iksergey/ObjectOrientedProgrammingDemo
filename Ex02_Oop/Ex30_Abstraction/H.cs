using static System.Console;

namespace Ex030_Abstraction
{
    // Два метода в разных интерфейсах


    interface IA0 { void Method(); }
    interface IB0 { void Method(); }

    class H0 : IA0, IB0
    {
        public void Method()
        {
            WriteLine("void Method()");
        }


        public static void Test()
        {
            IA0 h = new H0();
            h.Method(); // void Method()
            ((IA0)h).Method();// IA1.Method()
            ((IB0)h).Method();// IB1.Method()
        }
    }
























    // пример 1
    interface IA1 { public void Method() => WriteLine("IA1.Method()"); }
    interface IB1 { public void Method() => WriteLine("IB1.Method()"); }

    class H1 : IA1, IB1
    {
        public static void Test()
        {
            H1 h = new H1();
            ((IA1)h).Method();// IA1.Method()
            ((IB1)h).Method();// IB1.Method()
        }
    }


    // пример 2
    interface IA2 { public void Method() => WriteLine("IA2.Method()"); }
    interface IB2 { public void Method() => WriteLine("IB2.Method()"); }

    class H2 : IA2, IB2
    {
        public void MethodIA2() => (this as IA2).Method();
        public void MethodIB2() => (this as IB2).Method();
        public static void Test()
        {
            H2 h = new H2();
            h.MethodIA2();// IA2.Method()
            h.MethodIB2();// IB2.Method()
        }
    }


    // пример 3
    interface IA3 { void Method(); }
    interface IB3 { void Method(); }

    class H3 : IA3, IB3
    {
        void IA3.Method() => WriteLine("IA3.Method()");
        void IB3.Method() => WriteLine("IA3.Method()");
 
        public static void Test()
        {
            H3 h = new H3();
            (h as IB3).Method(); // IA3.Method()
            (h as IB3).Method(); // IA3.Method()
        }
    }



    // пример 4
    interface IA4 { void Method(); }
    interface IB4 { void Method(); }

    class H4 : IA4, IB4
    {
        void IA4.Method() => WriteLine("IA4.Method()");
        void IB4.Method() => WriteLine("IA4.Method()");

        public void MethodIA4() => (this as IA4).Method();
        public void MethodIB4() => (this as IB4).Method();

        public static void Test()
        {
            H4 h = new H4();
            h.MethodIA4(); // IA4.Method()
            h.MethodIB4(); // IA4.Method()
        }
    }
}
