namespace ListTask;
class Program
{
    static void Main(string[] args)
    {
        //tuple

        List<(string name, int creation)> languages = new List<(string, int)>();

        languages.Add(("C#", 2000));
        languages.Add(("C", 1972));
        languages.Add(("Python", 1989));
        languages.Add(("Java", 1995));
        languages.Add(("C++", 1983));


        Sort(languages);

        foreach (var item in languages)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }

    //Insertion sort 

    public static void Sort(List<(string name, int creation)> languages)
    {
        for (int i = 1; i < languages.Count; i++)
        {
            var key = languages[i];
            var j = i - 1;

            while (j >= 0 && key.creation < languages[j].creation)
            {
                languages[j + 1] = languages[j];
                j--;
            }

            languages[j + 1] = key;
        }
    }
}

