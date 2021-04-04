using BookReader.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReader.Library
{
    public abstract class Book :IBook
    {
        public Book(string title, string author, string language, IView view)
        {
            this.Author = author;
            this.Title = title;
            this.Language = language;
            this.view = view;

            pageNumber = 0;
        }



        protected int pageNumber;
        protected IView view;
        protected string[] pages;

        public bool IsFirstPage => pageNumber < 0;
        public bool IsLasrPage => pageNumber >= pages.Length;

        protected void Display()
        {
            if (IsFirstPage)
            {
                pageNumber = 0;
                view.Show("This first page");
            } else if(IsLasrPage)
            {
                pageNumber = pages.Length - 1;
                view.Show("This last page");
            } else
            {
                view.Show(pages[pageNumber]);
            }
        }


        public string Title { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }


        public void Preview(IProvider context)
        {
            context.Preview(pages);
            
        }


        public void FirstPage()
        {
            pageNumber = 0;
            Display();
        }

        public void LastPage()
        {
            pageNumber = pages.Length - 1;
            Display();
        }

        public void NextPage()
        {
            pageNumber++;
            Display();
        }

        public void PreviousPage()
        {
            pageNumber--;
            Display();
        }


    }
}
