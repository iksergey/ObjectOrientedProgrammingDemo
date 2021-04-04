using System;

namespace Ex020_Encapsulation
{

    class Program
    {
        static void Main(string[] args)
        {
            Windranger windranger = new Windranger();
            
            // windranger.Health = 2220;

            Console.WriteLine(windranger.Health);
            Console.WriteLine(windranger.Items);
            
            
        }
    }
}
