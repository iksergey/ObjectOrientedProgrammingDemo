using System;

namespace Ex026_Polymorphism
{


    // Конструкторы. Порядок вызова
    // Двойная инициализация

    class A
    {
        public int PropertyA { get; set; }
        public A()
        {
            Console.WriteLine("public A()");

            PropertyA = 0;
        }

        public A(int propertyAValue)
        {
            Console.WriteLine("public A(int propertyValue)");

            this.PropertyA = propertyAValue;
        }
    }


    class B : A

    {
        public int PropertyB { get; set; }
        public B()
        {
            Console.WriteLine("public B()");

            base.PropertyA = 0;
            this.PropertyB = 0;
        }

        public B(int propertyBValue)
        {
            Console.WriteLine("public B(int propertyBValue)");

            base.PropertyA = 0;
            this.PropertyB = propertyBValue;
        }

        public B(int propertyAValue, int propertyBValue)
        {
            Console.WriteLine("public B(int propertyAValue, int propertyBValue)");

            base.PropertyA = propertyAValue;
            this.PropertyB = propertyBValue;
        }
    }

    #region ToDo

    class C : A
    {
        public int PropertyC { get; set; }

        public C(int propertyAValue, int propertyCValue)
            : base(propertyAValue)
        {
            this.PropertyC = propertyCValue;

            Console.WriteLine("public C(int propertyAValue, int propertyCValue) : base(propertyAValue)");
        }

    }

    #endregion



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n  new A();");
            new A();

            Console.WriteLine("\n  new A(28);");
            new A(28);

            Console.WriteLine("\n  new B(28);");
            new B(28);

            Console.WriteLine("\n  new B(28, 9);");
            new B(28, 9);


            #region ToDo

            Console.ReadLine();
            Console.WriteLine("\n  new C(9, 1990);");

            new C(9, 1990);

            Console.ReadLine();

            #endregion

            #region ToDo2

            int numb1 = 1;
            numb1 = 1;

            int numb2 = 2;
            numb2 = 2;

            int numb3 = numb1 + numb2;
            numb3 = numb1 + numb2;



            #endregion


            #region *cast

            Console.WriteLine("\n---\n");

            A a = new A(); Console.WriteLine();
            B b = new B(); Console.WriteLine();

            A upCast = (A)b; ; Console.WriteLine();
            // upCast.PropertyB = 1; // Ошибка CS1061  "A" не содержит определения "PropertyB"
            
            // Инкапсуляция? не, не слышал
            Console.WriteLine($"upCast == b: {upCast == b}"); // True

            B downCast = (B)upCast;

            Console.WriteLine($"upCast == downCast: {upCast == downCast}"); // True
            Console.WriteLine($"b == downCast: {b == downCast}"); // True

            // InvalidCastException: Unable to cast object of type
            // 'Ex026_Polymorphism.A' to type 'Ex026_Polymorphism.B'.

            //B invalidDownCast = (B)a; 
            // 


            #endregion





            Console.ReadLine();

        }
    }
}