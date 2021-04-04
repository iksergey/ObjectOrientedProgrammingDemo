using System;

namespace Ex025_Polymorphism

{
    static class Randomize
    {
        static readonly Lazy<Random> rand;
        static Randomize() => rand = new Lazy<Random>();
        static public int GetNumber(int min, int max) => rand.Value.Next(min, max);
        static public int GetNumber(int max) => rand.Value.Next(0, max);

    }
}
