using System;
namespace LibraryApp23._10.Exceptions
{
    public class BookNotFoundException : Exception
    {
        private const string _message = "Kitab tapilmadi.";
        public BookNotFoundException(string message = _message) : base(message)
        {
        }
    }
}

