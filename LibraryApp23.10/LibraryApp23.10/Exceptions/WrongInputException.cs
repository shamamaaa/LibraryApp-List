using System;
namespace LibraryApp23._10.Exceptions
{
	public class WrongInputException:Exception
	{
        private const string _message = "Duzgun deyer daxil edin";

        public WrongInputException(string message = _message) : base(message)
        {
        }
    }
}

