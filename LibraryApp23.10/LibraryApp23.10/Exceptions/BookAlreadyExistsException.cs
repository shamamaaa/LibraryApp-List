using System;
namespace LibraryApp23._10.Exceptions
{
    public class BookAlreadyExistsException : Exception
    {
        private const string _message = "Kitab artiq var";
        public BookAlreadyExistsException(string message = _message) : base(message)
        {
        }
    }
}

