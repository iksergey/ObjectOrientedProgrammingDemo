using BookReader.Interfaces;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace BookReader.Library.Novels
{
    public class WarAndPeace : Book
    {
        public WarAndPeace(IView view)
            : base("War and Peace", "Leo Tolstoy", "English", view)
        {
            base.pages = new string[]{
                "Well, Prince, so Genoa and Lucca are now just family estates of the",
                "Buonapartes.But I warn you, if you don’t tell me that this means war,",
                "if you still try to defend the infamies and horrors perpetrated by that",
                "Antichrist—I really believe he is Antichrist—I will have nothing",
                "more to do with you and you are no longer my friend, no longer my",
                "‘faithful slave,’ as you call yourself!But how do you do? I see I",
                "have frightened you—sit down and tell me all the news."
            };
        }
    }
}
