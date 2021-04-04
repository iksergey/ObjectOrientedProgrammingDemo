using System;

namespace Ex0210_Inheritance
{

    class Parent
    {
        public int PublicProperty { get; set; }
        private int PrivateProperty { get; set; }
        protected int ProtectedProperty { get; set; }
        internal int InternalProperty { get; set; }
        protected internal int ProtectedInternalProperty { get; set; }
        private protected int PrivateProtectedProperty { get; set; }
    }


    class Heir : Parent
    {
        public Heir()
        {
            base.PublicProperty = 0;
            base.ProtectedProperty = 0;

            base.InternalProperty = 0;
            base.PrivateProtectedProperty = 0;
            base.ProtectedInternalProperty = 0;
            
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var a = new Parent();
            a.InternalProperty = 0;
            a.ProtectedInternalProperty = 0;
            a.PublicProperty = 0;
            

            var b = new Heir();
            b.InternalProperty = 0;
            b.ProtectedInternalProperty = 0;
            b.PublicProperty = 0;
            
            


        }
    }
}
