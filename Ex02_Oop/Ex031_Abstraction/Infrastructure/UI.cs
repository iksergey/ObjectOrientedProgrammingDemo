using BookReader.Interfaces;
using System;

namespace BookReader.Infrastructure
{
    public class UI
    {
        public void Start(IBook book)
        {
            ConsoleKey key;
            bool flag = true;

            Console.WriteLine("  < - PreviousPage\n  > - NextPage");
            Console.WriteLine("  ^- FirstPage\n  v - LastPage)");
            Console.WriteLine("  x - xml, j - json, t - txt");
            Console.WriteLine("  Esc to exit\n\n");

            while (flag)
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow: book.FirstPage(); break;
                    case ConsoleKey.DownArrow: book.LastPage(); break;
                    case ConsoleKey.LeftArrow: book.PreviousPage(); break;
                    case ConsoleKey.RightArrow: book.NextPage(); break;
                    case ConsoleKey.J: book.Preview(new JsonProvider()); break;
                    case ConsoleKey.T: book.Preview(new TxtProvider()); break;
                    case ConsoleKey.X: book.Preview(new XmlProvider()); break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Exit? y/n");
                        if (Console.ReadKey(true).KeyChar == 'y') flag = false;
                        break;
                }
            }
        }

    }
}
