namespace Ex030_Abstraction
{

    interface IInterface1 { }
    interface IInterface2 { }
    interface IInterface3 { }
    interface IInterface4 : IInterface2 { }

    interface IInterface5 : IInterface2, IInterface3 { }

    class G : IInterface1, IInterface5
    {

    }

    struct MyStruct : IInterface1, IInterface5
    {

    }
}
