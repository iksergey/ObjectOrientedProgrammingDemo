using System;

namespace Ex030_Abstraction
{
    interface IFromFInterface
    {
        #region _

        public class MyClass
        {
            #region _


            class MyClass2
            {
                interface IInterface3
                {
                    class MyClass3 : IInterface3
                    {

                    }
                }
            }

            #endregion

        }
        
        #endregion

        public const int year = 2020;
        public static int val;

        static IFromFInterface()
        {
            val = 0;
            SampleMethod3();
        }
        public void SampleMethod1() => val = year + 1;
        public int SampleMethod2();
        private static void SampleMethod3() { }
        public void SampleMethod4() { Console.WriteLine("IFromFInterface.SampleMethod4()"); }
        public void SampleMethod5() { Console.WriteLine("IFromFInterface.SampleMethod5()"); }

    }
}
