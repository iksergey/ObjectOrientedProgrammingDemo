using System;

namespace Ex030_Abstraction
{
    class E : IFromEInterface
    {
        public Type this[int index] { get { return typeof(int); } set { } }

        public int Property { get => field; set => field = value; }
        private int field;

        public event Action Event { add { MyEvent += value; } remove { MyEvent -= value; } }
        private event Action MyEvent;

        public void SampleMethod1() { }
    }
}
