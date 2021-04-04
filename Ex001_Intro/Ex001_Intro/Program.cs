using System;

namespace Ex001_Intro
{





    class A { }

    class B { }

    // Ошибка CS1721  Класс "C" не может иметь несколько базовых классов

    class C : A //, B
    {
        
    }

    struct D { }
    //struct E : D { }

    //struct F : A { }




    class MyClass : Object
    {
        public MyClass()
        {
            base.
        }
    }

    struct MyStruct // : ValueType
    {

    }














    class Program
    {
        class Worker
        {
            static int count;
            public Worker() => count++;
            public int Age { get; set; }
            public int Salary { get; set; }
            public string Name { get; set; }
            public void Greeting() => Console.WriteLine("Йуууухууу! Всем Profcsharp из 2021");
        }

        static void Main()
        {
            Worker worker = new() 
            { 
                Age = 30, 
                Name = "Serenya", 
                Salary = -10 
            };

            Worker[] workers = new Worker[1000];
            workers[0] = worker;
            foreach (var item in workers)
            {
                item.Greeting();
            }
        }
    }
}
