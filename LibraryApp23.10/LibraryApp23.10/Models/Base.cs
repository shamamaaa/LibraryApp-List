using System;
namespace LibraryApp23._10.Models
{
    public abstract class Base
    {
        private string _name;
        public int Id { get; protected set; }
        public string Name { get; protected set; }

        public Base(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id}-{Name}";
        }
    }
}

