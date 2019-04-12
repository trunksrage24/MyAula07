using System;
using System.Collections.Generic;
using System.Text;

namespace BookManager
{
    class Book
    {
        private string title;
        private string author;
        private int pages;
        private int wordCount;
        private static int bookCount;

        public Book(string title , string author)
        {
            this.title = title;
            this.author = author;
        }

         public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string title)
        {
            if (title != null && title.Length > 0)
            {
                this.title = title;
            }
        }
        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }
        public int GetTitleLength()
        {
            return title.Length;
        }
        public static int GetBookCount() => bookCount;

       public static Book()
        {
            bookCount = 0;
        }
        public Book(static title, static author)
        {
            this.title = title;
            this.author = author;
            bookCount++;
    }
}
