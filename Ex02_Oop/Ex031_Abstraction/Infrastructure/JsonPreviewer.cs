using BookReader.Interfaces;
using System;
using System.Text.Json;
using static System.Console;

namespace BookReader.Infrastructure
{
    public class JsonProvider : IProvider
    {
        public void Preview(string[] text)
        {
            WriteLine(JsonSerializer.Serialize<string[]>(text));
            Console.WriteLine("\n");
        }
    }

}
