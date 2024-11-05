using System.Collections.Generic;

namespace PracticingListsAndArrays;

class Program
{
    static void Main(string[] args)
    {
        var carlyFavs = new List<string>();

        var negativeNumbers = new List<int>();

        for (int i = 1; i < 67; i+=2)
        {
            negativeNumbers.Add(i);
        }

        Console.WriteLine("Negative numbers less than 67 include:");
        foreach (var number in negativeNumbers)
        {
            Console.WriteLine(number);
        }
    }
}