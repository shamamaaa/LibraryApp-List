using System;
namespace LibraryApp23._10.Exceptions
{
	public class CategoryAlreadyExistsException:Exception
	{
        private const string _message = "Kateqoriya artiq var.";
        public CategoryAlreadyExistsException(string message = _message) : base(message)
        {
		}
	}
}

