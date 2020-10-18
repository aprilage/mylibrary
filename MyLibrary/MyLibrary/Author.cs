using System;
using System.Collections.Generic;
namespace MyLibrary
{
    public class Author
    {
        private string _fullName;
        private string _hometown;
        private List<Book> _books;

        public Author(string fullName)
        {
            _fullName = fullName;
        }
    }
}
