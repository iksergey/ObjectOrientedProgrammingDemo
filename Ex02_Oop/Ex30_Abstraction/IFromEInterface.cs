using System;

namespace Ex030_Abstraction
{
    interface IFromEInterface
    {
        void SampleMethod1();
        int Property { get; set; }
        Type this[int index] { get; set; }
        event Action Event;
    }
}
