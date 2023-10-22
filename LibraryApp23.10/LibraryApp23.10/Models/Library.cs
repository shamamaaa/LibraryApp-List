using System;
namespace LibraryApp23._10.Models
{
    public class Library : Base
    {
        private static int Count = 0;
        List<Book> _books = new List<Book>();

        public Library(string name) : base(name)
        {
            Count++;
            Id = Count;
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void ListAllBooks()
        {
            foreach (Book book in _books)
            {
                Console.WriteLine(book);
            }
        }

    }
}

