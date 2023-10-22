using System;
namespace LibraryApp23._10.Exceptions
{
	public class LibraryNotFoundException:Exception
	{
        private const string _message = "Kitabxana tapilmadi.";

        public LibraryNotFoundException(string message = _message) : base(message)
        {
        }
    }
}

