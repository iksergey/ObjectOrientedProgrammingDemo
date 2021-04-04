using BookReader.Infrastructure;
using BookReader.Library.Novels;
using BookReader.Views;
namespace BookReader
{
    class Program
    {
        static void Main(string[] args)
        {
            new UI().Start(
                new WarAndPeace(
                    new ConsoleView())
                );
        }
    }
}
