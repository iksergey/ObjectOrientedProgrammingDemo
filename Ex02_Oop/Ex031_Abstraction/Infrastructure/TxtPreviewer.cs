using BookReader.Interfaces;
using System;

namespace BookReader.Infrastructure
{
    public class TxtProvider : IProvider
    {
        public void Preview(string[] text)
        {
            foreach (var line in text)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("\n");
        }
    }

}
