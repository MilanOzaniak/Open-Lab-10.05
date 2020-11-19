using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._05
{
    public class Book
    {
        private string title;
        private string author;
        private string category;
        private int pages;
        private int releaseDate;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Category
        {
            set { category = value; }
        }
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }
        public int ReleaseDate
        {
            get { return releaseDate; }
            set
            {
                if (value > 2021)
                {
                    releaseDate = -1;
                }
                else if (value < 1450)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }
        }
        public string Print
        {
            get { return $" Title is: {title}\n " +
                    $"Author: {author}\n " +
                    $"Release date: {releaseDate}\n " +
                    $"Category of the book: {category}\n " +
                    $"Number of pages: {pages}"; }
        }

        public static List<string> categoryList = new List<string> {"for kids", "romantic", "educational", "sci-fi", "adventure"};
       

        public Book()
        {
            title = "-1";
            author = "-1";
            releaseDate = -1;
            category = "-1";
            pages = -1;
        }

        public Book(string title, int pages)
        {
            Title = title;
            author = "-1";
            releaseDate = -1;
            category = "-1";
            Pages = pages;
        }

        public Book(string title, string author, int releaseDate, string category, int pages)
        {

            Title = title;
            Author = author;
            ReleaseDate = releaseDate;
            Category = category;
            Pages = pages;
        }
    }
}
