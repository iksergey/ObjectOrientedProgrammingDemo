using System;

namespace Ex030_Abstraction
{
    class D : C
    {
        public override Type this[int index] { get { return typeof(int); } set { } }

        public override int Property { get => field; set => field = value; }
        private int field;

        public override event Action Event 
        { 
            add { dEvent += value; } 
            remove { dEvent -= value; } 
        }
        private event Action dEvent;
        public override void SampleMethod1() { }
    }
}
