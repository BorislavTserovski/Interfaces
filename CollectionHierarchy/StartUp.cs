using System;
using System.Collections.Generic;



public class StartUp
{
    public static void Main()
    {
        string[] inputLine = Console.ReadLine().Split();
        AddCollection<string> addCollection = new AddCollection<string>();
        AddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();
        MyList<string> myList = new MyList<string>();
        List<int> addNums = new List<int>();
        List<int> addRemoveInts = new List<int>();
        List<int> listInts = new List<int>();

        foreach (var item in inputLine)
        {
            addNums.Add(addCollection.Add(item));
            addRemoveInts.Add(addRemoveCollection.Add(item));
            listInts.Add(myList.Add(item));
        }

        Console.WriteLine(string.Join(" ", addNums));
        Console.WriteLine(string.Join(" ", addRemoveInts));
        Console.WriteLine(string.Join(" ", listInts));

        int removeActions = int.Parse(Console.ReadLine());
        for (int i = 0; i < removeActions; i++)
        {
            Console.Write(addRemoveCollection.Remove() + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < removeActions; i++)
        {
            Console.Write(myList.Remove() + " ");
        }
        Console.WriteLine();
    }
}

