using System;
namespace MyLibrary
{
    public class Book
    {
        private string _title;
        private Author _author;
        private string _genre;
        private double _rating;

        public Book(string title, Author author)
        {
            _title = title;
            _author = author;
        }
    }
}
