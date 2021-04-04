using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex023_Inheritance.Infrastructure
{
    static class Randomize
    {
        static Random rand;
        static Randomize()
        {
            rand = new Random();
        }
        static public byte Value(int from = 0, int to = 0, int koff = 1)
        {
            if (from == to) return (byte)(rand.Next(200, 255) * koff);
            return (byte)((from > to ? rand.Next(from) : rand.Next(from, to)) * koff);
        }

    }
}
