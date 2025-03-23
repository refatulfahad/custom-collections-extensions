using CustomFindAllEven;

internal class Program
{
    private static void Main(string[] args)
    {
        Program program = new Program();

        Console.WriteLine("Extension Method");
        program.FindEvenNumbers();


        Console.WriteLine("\nCustom generic type using builtIn list!");
        program.CallRefatList();


        Console.WriteLine("\nCustom generic type using linked list!");
        program.CallRefatLinkedList();
    }

    public void FindEvenNumbers()
    {
        Random random = new Random();

        List<int> numbers = Enumerable.Range(0, 10).Select(_ => random.Next(1, 100)).ToList();

        bool IsEven(int n) => n % 2 == 0;
        IEnumerable<int> evenNumber = numbers.FindEvenNumbers(IsEven);

        Console.WriteLine("\nCustom FindEvenNumbers() function!");

        foreach (var item in evenNumber)
        {
            Console.WriteLine(item);
        }
    }

    public void CallRefatList()
    {
        Random random = new Random();

        //RefatList<int> refat = new RefatList<int>();
        RefatList<int> refat = new RefatList<int> { 1, 2, 3 };
        //refat.Add(1);
        //refat.Add(2);
        //refat.Add(3);

        List<int> list = refat.GetAll();
        foreach (var item in refat)
            Console.WriteLine(item);

        refat[0] = 5;
        Console.WriteLine("\nHello, World!");

        for (int i = 0; i < refat.Count(); i++)
        {
            Console.WriteLine(refat[i]);
        }
    }

    public void CallRefatLinkedList()
    {
        RefatLinkedList<int> refatCustom = new RefatLinkedList<int>();
        refatCustom.Add(10);
        refatCustom.Add(20);
        refatCustom.Add(30);

        foreach (var item in refatCustom.GetAll())
            Console.WriteLine(item);

        Console.WriteLine("\nFirstOrDefault() method");
        Console.WriteLine(refatCustom.FirstOrDefault());
        Console.WriteLine(refatCustom.FirstOrDefault(x => ((x / 10) % 2) == 0));

        //RefatLinkedList<string> list2 = new RefatLinkedList<string>(new string[] { "refat", "riyad", "rafat", "rafid" });
        //This is using a feature in C# called collection initializers.
        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers#collection-initializers

        RefatLinkedList<string> refatLinkedList = new RefatLinkedList<string> { "refat", "riyad", "rafat", "rafid" };

        Console.WriteLine("\nCollection initializers");
        foreach (var item in refatLinkedList)
            Console.WriteLine(item);

        Console.WriteLine("\nFirstOrDefault() method");
        Console.WriteLine(refatLinkedList.FirstOrDefault());
        Console.WriteLine(refatLinkedList.FirstOrDefault(x => x == "rafid"));
        Console.WriteLine(refatLinkedList.FirstOrDefault(x => x.StartsWith("ri")));
    }
}


