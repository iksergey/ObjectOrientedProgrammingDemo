using BookReader.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReader.Views
{
    public class ConsoleView : IView
    {
        public void Show(string s)
        {
            Console.WriteLine(s);
        }
    }
}
