using LibraryApp23._10.Exceptions;
using LibraryApp23._10.Models;

namespace LibraryApp23._10;
class Program
{
    static void Main(string[] args)
    {
        List<Library> libraries = new List<Library>();
        List<Category> categories = new List<Category>();
        List<Book> books = new List<Book>();

        restartMenu:
        Console.WriteLine("==========");
        Console.WriteLine("Ana Menyu");
        Console.WriteLine("==========");
        Console.WriteLine("[1] Yeni kitabxana yarat");
        Console.WriteLine("[2] Yeni Kateqoriya yarat");
        Console.WriteLine("[3] Yeni kitab yarat");
        Console.WriteLine("[4] Kitabxanaya daxil ol");
        Console.WriteLine("[0] Proqramdan cix");
        Console.WriteLine("Secim edin:");

        string choice = Console.ReadLine();

        try
        {
            switch (choice)
            {
                case "1":
                    CreateLibrary(libraries);
                    break;
                case "2":
                    CreateCategory(categories);
                    break;
                case "3":
                    CreateBook(books,categories);
                    break;
                case "4":
                    ChooseLibrary(libraries);
                    break;
                case "0":
                    return;

                default: throw new WrongInputException();
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        goto restartMenu;
    }

    public static void CreateLibrary(List<Library> libraries)
    {
        Console.WriteLine("\n----------");
        Console.WriteLine("Yeni kitabxana yarat:");
        Console.WriteLine("----------");

        while (true)
        {
            Console.Write("Kitabxananin adini daxil edin:");
            string name = Console.ReadLine().Trim();
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

            foreach (var item in libraries)
            {
                if (item.Name == name)
                {
                    throw new LibraryAlreadyExistsException();

                }
            }

            if (name.Length >= 3 && name.Length < 25)
            {
                Library library = new Library(name);
                libraries.Add(library);
                Console.WriteLine($"'{name}'adli kitabxana yaradildi.");
                Console.WriteLine("[Press Enter]");
                Console.ReadLine();
            }
            else
            {
                throw new WrongInputException();
            }
            break;
        }
    }

    public static void CreateCategory(List<Category> categories)
    {
        Console.WriteLine("\n----------");
        Console.WriteLine("Yeni kateqoriya yarat:");
        Console.WriteLine("----------");

        while (true)
        {
            Console.Write("Kateqoriya adini daxil edin:");
            string name = Console.ReadLine().Trim();
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

            foreach (var item in categories)
            {
                if (item.Name == name)
                {
                    throw new CategoryAlreadyExistsException();

                }
            }

            if (name.Length >= 3 && name.Length < 25)
            {
                Category category = new Category(name);
                categories.Add(category);
                Console.WriteLine($"'{name}'adli kateqoriya yaradildi.");
                Console.WriteLine("[Press Enter]");
                Console.ReadLine();
            }
            else
            {
                throw new WrongInputException();
            }
            break;
        }
    }

    public static void CreateBook(List<Book> books, List<Category> categories)
    {
        Console.WriteLine("\n----------");
        Console.WriteLine("Yeni kitab yarat:");
        Console.WriteLine("----------");

        while (true)
        {
            Console.Write("Kitabin adini daxil edin:");
            string name = Console.ReadLine().Trim();
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

            Console.Write("Kitabin yazarini daxil edin:");
            string author = Console.ReadLine().Trim();
            author = char.ToUpper(author[0]) + author.Substring(1).ToLower();

            foreach (var item in books)
            {
                if (item.Name == name && item.Autor == author)
                {
                    throw new BookAlreadyExistsException();
                }
            }

            if (name.Length >= 3 && name.Length < 25 && author.Length >= 3 && author.Length < 25)
            {
                var category = ChooseCategory(categories);
                Book book = new(name, author, category);
                books.Add(book);
                Console.WriteLine($"'{name}'adli kitab yaradildi.");
                Console.WriteLine("[Press Enter]");
                Console.ReadLine();
            }
            else
            {
                throw new WrongInputException();
            }
            break;
        }
    }

    public static Category ChooseCategory(List<Category> categories)
    {
        Console.WriteLine("\nKateqoriya secin:");
        foreach (var item in categories)
        {
            Console.WriteLine(item);
        }

        bool input = int.TryParse(Console.ReadLine(), out int id);
        if (!input)
        {
            throw new WrongInputException();
        }
        foreach (Category category in categories)
        {
            if (category.Id == id)
            {
                return category;
            }
        }
        throw new CategoryNotFoundException();
    }

    //Library hissesi

    public static Library ChooseLibrary(List<Library>libraries)
    {
        Console.WriteLine("\nKitabxana secin:");
        foreach (var item in libraries)
        {
            Console.WriteLine(item);
        }

        bool input = int.TryParse(Console.ReadLine(), out int id);
        if (!input)
        {
            throw new WrongInputException();
        }
        foreach (Library library in libraries)
        {
            if (library.Id == id)
            {
                Console.Clear();
                LibraryMenu(library);
            }
        }
        throw new LibraryNotFoundException();
    }

    public static void LibraryMenu(Library library)
    {
        restartLibraryMenu:

        Console.WriteLine("\n----------");
        Console.WriteLine($"{library.Name} Kitabxana menyusu");
        Console.WriteLine("----------");
        Console.WriteLine("[1] Kitab elave et");
        Console.WriteLine("[2] Kitablari goster");
        Console.WriteLine("[3] Kitabxanadan cix");
        Console.WriteLine("Secim edin:");

        string choice1 = Console.ReadLine();

        try
        {
            switch (choice1)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default: throw new WrongInputException();
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        goto restartLibraryMenu;

    }

    //Library methodlari


}

