using System;
namespace LibraryApp23._10.Models
{
    public class Book : Base
    {
        private static int Count = 0;
        public string Autor { get; set; }
        public Category Category { get; set; }

        public Book(string name, string author, Category category) : base(name)
        {
            Count++;
            Id = Count;
        }
    }
}

