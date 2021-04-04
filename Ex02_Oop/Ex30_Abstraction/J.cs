using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex030_Abstraction
{
    class J
    {
        static void Test()
        {
            new J1().MethodJ();
            new J2().MethodJ();
            new J3().MethodJ();
            new J4().MethodJ();

            new J5().Method();
            new J6().Method();
        }
    }

    class J1
    {
        public void MethodJ() { }
    }

    class J2 : J1 { }
    class J3 : J2 { }
    class J4 : J3 { }


    interface IJ
    {
        void Method();
    }

    class J5 : IJ
    {
        public void Method() { }
    }

    class J6 : J5
    {

    }

}
