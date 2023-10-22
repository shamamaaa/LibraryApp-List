using System;
namespace LibraryApp23._10.Models
{
    public class Category : Base
    {
        private static int Count = 0;

        public Category(string name) : base(name)
        {
            Count++;
            Id = Count;
        }

    }
}

