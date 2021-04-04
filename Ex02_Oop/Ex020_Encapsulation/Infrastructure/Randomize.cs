using System;

namespace Ex020_Encapsulation.Infrastructure
{
    static class Randomize
    {
        static readonly Random rand;
        static Randomize() => rand = new Random();

        static public byte Value(int from = 0, int to = 0, int koff = 1)
        {
            return from == to ? (byte)(rand.Next(200, 255) * koff) 
                              : (byte)((from > to ? rand.Next(from) 
                              : rand.Next(from, to)) * koff);
        }

    }
}
