using Ex027_MagicWords.Sealed;
using System;
using static System.Console;

namespace Ex027_MagicWords
{
    namespace Abstract
    {
        // abstract
        // изменяемый элемент имеет отсутствующую или неполную или реализацию

        abstract class A { }
        class B : A { }

        abstract class C
        {
            public abstract void Method();
            public abstract int Property { get; set; }
            public abstract string this[int index] { get; set; }
            public abstract event Action Event;
        }

        class D : C
        {
            // Обязательна реализация всех abstract из класса C
            public override string this[int index] { get { return String.Empty; } set { } }
            public override int Property { get; set; }
            public override event Action Event;
            public override void Method() { }
        }
        class Demo
        {
            public static void View()
            {
                //A a = new A(); нельзя
                A a = new B();

                D d = new D();
                d.Event += () => { };
                d.Method();
                d.Property = 0;
                d[0] = new string('-', 10);
            }
        }
    }

    namespace Sealed
    {
        sealed class A { }
        // class B : A { } // Запрещено

        class C 
        {
            protected virtual void Method1() { }
            protected virtual void Method2() { }
        }

        class D : C 
        {
            public D()
            {
                Method1();
                Method2();
            }
            sealed protected override void Method2()
            {
                base.Method2();
            }
        }

        class E : D
        {
            public E()
            {
                Method1();
                Method2();
            }

        }

        class F : E
        {
            public F()
            {
                 
            }

             
        }

    }

    namespace New
    {
        class A
        {
            public void Method() => WriteLine("A.Method");
            public int value;
            public void M() { }
        }

        /// CS0108  "B.Method()" скрывает наследуемый член "A.Method()". 
        /// Если скрытие было намеренным, используйте ключевое слово new.	
        class B : A
        {
            new public void Method() => WriteLine("B.Method");
            new public int value;
            new int M;
 
        }


        public class Demo
        {
            static public void View()
            {
                A a = new A();
                a.Method();
                B b = new B();
                b.Method();

                A c = new B();
                c.Method();
            }
        }
    }

    namespace ThisBase
    {
        class A
        {
            public A(int a)
            {
                Property = a;
            }
            public A() { Property = default; }
            public void ShowProperty() => WriteLine($"a this.Property {this.Property}");
            public int Property { get; set; }
        }
        class B : A
        {
            public B()
                :base(1)
            {
                this.Property = 222;
                base.Property = 333;
            }
            new public int Property { get; set; }
            public void ShowThisProperty() => WriteLine($"b this.Property {this.Property}");
            public void ShowBaseProperty() => WriteLine($"b base.Property {base.Property}");
        }
        public class Demo
        {
            public static void View()
            {
                A a = new A();
                a.ShowProperty(); // A.a this.Property 111

                B b = new B();

                b.ShowThisProperty(); // b this.Property 222
                b.ShowBaseProperty(); // b base.Property 333

            }
        }
    }

    namespace Virtual
    {
        // virtual используется для изменения объявлений
        // - методов
        // - свойств
        // - индексаторов
        // - событий
        // virtual разрешает их переопределения в производном классе.

        class A { public void Method() => WriteLine("A.Method"); }
        class B : A { public new void Method() => WriteLine("B.Method"); }

        class C { public virtual void Method() => WriteLine("C.Method"); }
        class D : C { public new void Method() => WriteLine("D.Method"); }
        class E : C { public override void Method() => WriteLine("E.Method"); }

        public class Demo
        {
            public static void View()
            {
                A a = new A(); a.Method(); // A.Method
                B b = new B(); b.Method(); // B.Method
                A ab = new B(); ab.Method(); // A.Method

                C c = new C(); c.Method(); // C.Method
                D d = new D(); d.Method(); // D.Method
                E e = new E(); e.Method(); // E.Method

                C cd = new D(); cd.Method(); // C.Method
                C ce = new E(); ce.Method(); // E.Method
            }
        }


    }

    namespace Default
    {
        class A { }

        public class Demo
        {
            public static void View()
            {
                int i = default; WriteLine($"i = {i}"); // i = 0
                int d = default; WriteLine($"d = {d}"); // d = 0

                string s = default(string); WriteLine($"s = -{s}- {s == null}"); // s = -- True
                char c = default; WriteLine($"c = -{c}- {c == '\0'}"); // c = -- True
                bool b = default; WriteLine($"b = {b}"); // b = False
                A a = default; WriteLine($"a = {a} {a == null}"); // a =  True

            }
        }

        struct B
        {
            //public B()
            //{
            //    this.i = default;
            //    this.s = default;
            //    this.a = default;
            //}

            int i;
            string s;
            A a;

        }

    }

    namespace OperatorOverloading
    {
        // https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/operator-overloading
        #region msdn

        //Перегружаемые операторы
        //Следующая таблица содержит сведения о возможности перегрузки операторов C#:
        //ПЕРЕГРУЖАЕМЫЕ ОПЕРАТОРЫ
        //Операторы   Возможность перегрузки
        //+x, -x, !x, ~x, ++, --, true, false	
        //
        //Эти унарные операторы могут быть перегружены.

        //x + y, x - y, x* y, x / y, x % y, x & y, x | y, x ^ y,
        //x << y, x >> y, x == y, x != y, x<y, x> y, x <= y, x >= y
        //
        //Эти бинарные операторы могут быть перегружены.
        //Некоторые операторы должны перегружаться парами;

        //x && y, x || y Условный логический оператор не может быть перегружен.
        //При этом, если тип с перегруженными операторами true и false
        //также перегружает оператор & или |,
        //оператор && или ||, соответственно, может быть применен для операндов этого типа.

        //a[i], a?[i] Доступ к элементам не считается перегружаемым оператором,
        //но вы можете определить индексатор.
        //(T) x    Оператор приведения невозможно перегрузить,
        //но можно определить пользовательские преобразования типа и выполнять
        //его с помощью выражения приведения.

        //+=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=	
        //Составные операторы присваивания не могут быть перегружены явным образом.
        //Однако при перегрузке бинарного оператора соответствующий
        //составной оператор присваивания (если таковой имеется)
        //также неявно перегружается.Например, += вычисляется с помощью +, который может быть перегружен.

        //^x, x = y, x.y, x?.y, c? t : f, x ?? y, x ??= y, x..y, x->y, =>, f(x),
        //as, await, checked, unchecked, default, delegate, is, nameof,
        //new, sizeof, stackalloc, switch, typeof, with
        //Эти операторы не могут быть перегружены.



        #endregion
        class Item
        {
            public override string ToString() => $"{Prop}";
            public int Prop { get; set; }

            public static Item operator +(Item a, Item b) => new Item { Prop = a.Prop + b.Prop };
            public static Item operator -(Item a) => new Item { Prop = -a.Prop };

          

            //public static bool operator >(Item a, Item b) => a.Prop > b.Prop ;
            //public static bool operator <(Item a, Item b) => a.Prop < b.Prop ;

            public static Item operator >(Item a, Item b) => a.Prop > b.Prop ? a : b;
            public static Item operator <(Item a, Item b) => a.Prop < b.Prop ? a : b;


        }

        class IEItem
        {
            public int Prop { get; set; }

            public static implicit operator double(IEItem d) => d.Prop;
            public static explicit operator int(IEItem d) => d.Prop;

            public static implicit operator IEItem(byte d) => new IEItem { Prop = d };
            public static explicit operator IEItem(int d) => new IEItem { Prop = d };

        }


        class Demo
        {
            public static void View()
            {
                Item a = new Item { Prop = 11 }; WriteLine($"a : {a} "); // a : 11
                Item b = new Item { Prop = 33 }; WriteLine($"b : {b} "); // b = 22

                Item ab = a > b; WriteLine($"a > b : {ab} "); // a > b : 33
                Item ba = b > a; WriteLine($"b > a : {ba} "); // b > a : 33
                ba = b < a; WriteLine($"b < a : {ba} "); // b < a : 11

                Item c = a + b; WriteLine($"c : {c} "); // c : 33
                b = -a; WriteLine($"b = -a : {b} "); // b = -a : -11

                Console.WriteLine();

                var item = new IEItem { Prop = 2021 };
                WriteLine($"item.Prop : {item.Prop} "); // item.Prop : 2021

                double d = item; WriteLine($"d : {d} "); // d : 2021
                int i = (int)item; WriteLine($"i : {i} "); // i : 2021

                byte val = 123;
                IEItem newItem = val;

                int intVVal = 1222;
                newItem = (IEItem)intVVal;
            }
        }

    }

    namespace Question
    {
        #region ???
        //ex(im)plicit

        class Person
        {
            public byte Age { get; set; }
            public string FistName { get; set; }
            public static implicit operator User(Person p) =>
                new User 
                {
                    Age = p.Age,
                    Username = p.FistName,
                    Volume = 0
                };
        }
        class User
        {
            public byte Age { get; set; }
            public string Username { get; set; }
            public byte Volume { get; set; }
            public static explicit operator Person(User p) =>
                new Person
                {
                    Age = p.Age,
                    FistName = p.Username,
                };
        }
        #endregion
        class Demo
        {
            public static void View()
            {
                Person person = new Person();
                User user = new User();
                user = person;
                person = (Person)user;
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //New.Demo.View();
            //Virtual.Demo.View();
            //ThisBase.Demo.View();
            //Default.Demo.View();
            //OperatorOverloading.Demo.View();
            Question.Demo.View();


        }
    }
}