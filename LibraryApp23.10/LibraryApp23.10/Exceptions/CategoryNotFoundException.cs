using System;
namespace LibraryApp23._10.Exceptions
{
    public class CategoryNotFoundException : Exception
    {
        private const string _message = "Kateqoriya tapilmadi";

        public CategoryNotFoundException(string message = _message) : base(message)
        {
        }
    }
}

