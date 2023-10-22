using System;
namespace LibraryApp23._10.Exceptions
{
	public class LibraryAlreadyExistsException:Exception
	{
		private const string _message = "Kitabxana artiq var";
        public LibraryAlreadyExistsException(string message=_message):base(message)
		{
		}
	}
}

